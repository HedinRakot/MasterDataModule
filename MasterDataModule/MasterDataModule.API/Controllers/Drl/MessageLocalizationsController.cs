using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MessageLocalization })]
    /// <summary>
    ///     Controller for <see cref="MessageLocalization"/> entity
    /// </summary>
    public partial class MessageLocalizationsController: ClientApiController<MessageLocalizationModel, MessageLocalization, int, IMessageLocalizationManager>
    {

        public MessageLocalizationsController(IMessageLocalizationManager manager): base(manager){}

        protected override void EntityToModel(MessageLocalization entity, MessageLocalizationModel model)
        {
            model.validationErrorNumber = entity.ValidationErrorNumber;
            model.sysLanguageId = entity.SysLanguageId;
            model.message = entity.Message;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MessageLocalizationModel model, MessageLocalization entity, ActionTypes actionType)
        {
            entity.ValidationErrorNumber = model.validationErrorNumber;
            entity.SysLanguageId = model.sysLanguageId;
            entity.Message = model.message;
        }
    }
}
