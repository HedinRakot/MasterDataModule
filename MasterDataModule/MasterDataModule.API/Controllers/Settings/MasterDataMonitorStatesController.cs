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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataMonitorState })]
    /// <summary>
    ///     Controller for <see cref="MasterDataMonitorState"/> entity
    /// </summary>
    public partial class MasterDataMonitorStatesController: ClientApiController<MasterDataMonitorStateModel, MasterDataMonitorState, int, IMasterDataMonitorStateManager>
    {

        public MasterDataMonitorStatesController(IMasterDataMonitorStateManager manager): base(manager){}

        protected override void EntityToModel(MasterDataMonitorState entity, MasterDataMonitorStateModel model)
        {
            model.reconfigure = entity.Reconfigure;
            model.reconfigureCheckingTimeout = entity.ReconfigureCheckingTimeout;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataMonitorStateModel model, MasterDataMonitorState entity, ActionTypes actionType)
        {
            entity.Reconfigure = model.reconfigure;
            entity.ReconfigureCheckingTimeout = model.reconfigureCheckingTimeout;
        }
    }
}
