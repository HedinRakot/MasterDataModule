using MasterDataModule.API.Models;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Configuration;
using System;

namespace MasterDataModule.API.Controllers.Settings
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataSubscribers })]
    /// <summary>
    ///     Controller for <see cref="MasterDataSubscribers"/> entity
    /// </summary>
    public partial class MasterDataSubscribersController: ClientApiController<MasterDataSubscribersModel, MasterDataSubscribers, int, IMasterDataSubscribersManager>
    {

        public MasterDataSubscribersController(IMasterDataSubscribersManager manager): base(manager){}

        protected override void EntityToModel(MasterDataSubscribers entity, MasterDataSubscribersModel model)
        {
            model.email = entity.Email;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataSubscribersModel model, MasterDataSubscribers entity, ActionTypes actionType)
        {
            entity.Email = model.email;
        }
    }
}
