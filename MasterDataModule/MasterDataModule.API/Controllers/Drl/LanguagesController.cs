using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.Language })]
    /// <summary>
    ///     Controller for <see cref="Language"/> entity
    /// </summary>
    public partial class LanguagesController: ClientApiController<LanguageModel, Language, int, ILanguageManager>
    {

        public LanguagesController(ILanguageManager manager): base(manager){}

        protected override void EntityToModel(Language entity, LanguageModel model)
        {
            model.sysLanguageId = entity.SysLanguageId;
            model.oldAbbr = entity.OldAbbr;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(LanguageModel model, Language entity, ActionTypes actionType)
        {
            entity.SysLanguageId = model.sysLanguageId;
            entity.OldAbbr = model.oldAbbr;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
