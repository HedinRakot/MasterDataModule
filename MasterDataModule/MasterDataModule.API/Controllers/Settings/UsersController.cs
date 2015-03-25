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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.User })]
    /// <summary>
    ///     Controller for <see cref="User"/> entity
    /// </summary>
    public partial class UsersController: ClientApiController<UserModel, User, int, IUserManager>
    {

        public UsersController(IUserManager manager): base(manager){}

        protected override void EntityToModel(User entity, UserModel model)
        {
            model.masterDataRoleId = entity.MasterDataRoleId;
            model.login = entity.Login;
            model.name = entity.Name;
            model.password = entity.Password;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(UserModel model, User entity, ActionTypes actionType)
        {
            entity.MasterDataRoleId = model.masterDataRoleId;
            entity.Login = model.login;
            entity.Name = model.name;
            entity.Password = model.password;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;

            ExtraModelToEntity(entity, model, actionType);
        }
    }
}
