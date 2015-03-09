using TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Base;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Common;
using TuevSued.V1.IT.FE.Entities.MasterDataModule.Common;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers
{
    public class CollectionTypesModel
    {
        public bool permissions { get; set;}
        public bool roles { get; set; }
        public bool examClasses { get; set; }
        public bool sysTables { get; set; }
        public bool editModeTypes { get; set; }
        public bool returnReasons { get; set; }
        public bool assignationTypes { get; set; }
        public bool legalBasises { get; set; }
        public bool sysLanguages { get; set; }
        public bool coreDataProducts { get; set; }
        public bool accountingAreas { get; set; }
        public bool orgTypes { get; set; }
    }

    public class IdNameModel<TId>
        where TId : struct, IEquatable<TId>
    {
        public TId id { get; set; }
        public string name { get; set; }
    }

    public class ViewCollectionController: ApiController
    {
        private readonly IPermissionManager permissionManager;
        private readonly IRoleManager roleManager;
        private readonly IExamClassManager examClassManager;
        private readonly ISysTableManager sysTableManager;
        private readonly IReturnReasonManager returnReasonManager;
        private readonly ILegalBasisManager legalBasisManager;
        private readonly ISysLanguageManager sysLanguageManager;
        private readonly ICoreDataProductManager coreDataProductManager;
        private IOrgAccountingAreaManager accountingAreaManager;

        //TODO create Factory
        public ViewCollectionController(IPermissionManager permissionManager, IRoleManager roleManager,
            IExamClassManager examClassManager, ISysTableManager sysTableManager, IReturnReasonManager returnReasonManager,
            ILegalBasisManager legalBasisManager, ISysLanguageManager sysLanguageManager,
            ICoreDataProductManager coreDataProductManager, IOrgAccountingAreaManager accountingAreaManager)
        {
            this.accountingAreaManager = accountingAreaManager;
            this.permissionManager = permissionManager;
            this.roleManager = roleManager;
            this.examClassManager = examClassManager;
            this.sysTableManager = sysTableManager;
            this.returnReasonManager = returnReasonManager;
            this.legalBasisManager = legalBasisManager;
            this.sysLanguageManager = sysLanguageManager;
            this.coreDataProductManager = coreDataProductManager;
        }

        [Authorize]
        public IHttpActionResult Get([FromUri] CollectionTypesModel model)
        {
            if (model == null)
                return NotFound();

            var result = new Dictionary<string, IEnumerable<object>>();

            if (model.permissions)
                result.Add("permissions", GetViewCollection<Permission, int, IPermissionManager>(permissionManager));

            if (model.roles)
                result.Add("roles", GetViewCollection<Role, int, IRoleManager>(roleManager));

            if (model.examClasses)
                result.Add("examClasses", GetViewCollection<ExamClass, int, IExamClassManager>(examClassManager));

            if (model.sysTables)
                result.Add("sysTables", GetViewCollection<SysTable, int, ISysTableManager>(sysTableManager));

            if (model.returnReasons)
                result.Add("returnReasons", GetViewCollection<ReturnReason, int, IReturnReasonManager>(returnReasonManager));

            if (model.legalBasises)
                result.Add("legalBasises", GetViewCollection<LegalBasis, int, ILegalBasisManager>(legalBasisManager));

            if (model.sysLanguages)
                result.Add("sysLanguages", GetViewCollection<SysLanguage, int, ISysLanguageManager>(sysLanguageManager));

            if (model.coreDataProducts)
                result.Add("coreDataProducts", GetViewCollection<CoreDataProduct, int, ICoreDataProductManager>(coreDataProductManager));

            if (model.accountingAreas)
                //result.Add("accountingAreas", GetViewCollection<OrgAccountingArea, int, IOrgAccountingAreaManager>(accountingAreaManager));
            {
                result.Add("accountingAreas", new[]
                {
                    new {id = 0, accountingArea="accountArea1"},
                    new {id = 0, accountingArea="accountArea2"}
                });
            }

            if (model.orgTypes)
            {
                result.Add("orgTypes", new[]
                {
                    new {id = 0, name="orgTypes1"},
                    new {id = 0, name="orgType2"}
                });
            }

            //TODO localize
            if (model.editModeTypes)
                result.Add("editModeTypes", new[]
                {
                    new { id = "0", name = "nur lesen"},
                    new { id = "1", name = "editieren"},
                    new { id = "2", name = "editieren/anlegen"},
                    new { id = "3", name = "editieren/anlegen/löschen"},
                });

            if (model.assignationTypes)
                result.Add("assignationTypes", new[]
                {
                    new { id = 0, name = "Erweiterung"},
                    new { id = 1, name = "Ersterteilung"},
                    new { id = 2, name = "--"},
                });
			
			return Ok(result);
        }

        private IEnumerable<IdNameModel<TId>> GetReadOnlyViewCollection<TEntity, TId, TManager>(TManager manager)
            where TEntity : class, IHasId<TId>
            where TId : struct, IEquatable<TId>
            where TManager : IReadOnlyEntityManager<TEntity, TId>
        {
            var result = manager.GetEntities().Select(o => { return ToCollectionItem<TId>(o); });
            return result.ToList();
        }

        private IEnumerable<IdNameModel<TId>> GetViewCollection<TEntity, TId, TManager>(TManager manager)
            where TEntity : class, IHasId<TId>, IRemovable
            where TId : struct, IEquatable<TId>
            where TManager : IEntityManager<TEntity, TId>
        {
            var result = manager.GetEntities().Where(o => !o.DeleteDate.HasValue)
                .Select(o => { return ToCollectionItem<TId>(o); });
            return result.ToList();
        }

        private IdNameModel<TId> ToCollectionItem<TId>(IHasId<TId> item)
            where TId : struct, IEquatable<TId>
        {
            if (item is IHasTitle)
                return new IdNameModel<TId> { id = item.Id, name = ((IHasTitle)item).EntityTitle };

            return new IdNameModel<TId> { id = item.Id, name = item.Id.ToString() };
        }
    }
}
