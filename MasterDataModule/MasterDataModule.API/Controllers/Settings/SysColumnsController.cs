using MasterDataModule.API.Models;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Configuration;
using System;

namespace MasterDataModule.API.Controllers.Settings
{
    /// <summary>
    ///     Controller for <see cref="SysColumn"/> entity
    /// </summary>
    public partial class SysColumnsController: ClientApiController<SysColumnModel, SysColumn, int, ISysColumnManager>
    {

        public SysColumnsController(ISysColumnManager manager): base(manager){}

        protected override void EntityToModel(SysColumn entity, SysColumnModel model)
        {
            model.sysTableId = entity.SysTableId;
            model.description = entity.Description;
            model.readOnly = entity.ReadOnly;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(SysColumnModel model, SysColumn entity, ActionTypes actionType)
        {
            entity.SysTableId = model.sysTableId;
            entity.Description = model.description;
            entity.ReadOnly = model.readOnly;
        }
    }
}
