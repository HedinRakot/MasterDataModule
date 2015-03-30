using System;
using System.Linq;
using System.Web.Http;
using MasterDataModule.API.Models;
using TuevSued.V1.IT.FE.CoreBase;
using TuevSued.V1.IT.FE.CoreBase.Localization;
using MasterDataModule.Contracts;
using System.Collections.Generic;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers.Configuration;
using System.Linq.Dynamic;

namespace MasterDataModule.API.Controllers.Settings
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.SysColumn })]
    public partial class SysColumnsController
    {
        protected void ExtraEntityToModel(SysColumn entity, SysColumnModel model)
        {
            var description = StringHelper.GetTextForCurrentLocale(entity.Description,
                CultureManager.Current.CurrentCulture);
            model.columnDescription = String.Format("{0} ({1})", description, entity.Name);
        }

        protected override IQueryable<SysColumn> Sort(IQueryable<SysColumn> entities, Sorting sorting)
        {
            if (sorting.Field == "columnDescription")
                return entities.OrderBy("Description " + sorting.Direction);

            return base.Sort(entities, sorting);
        }
    }
}