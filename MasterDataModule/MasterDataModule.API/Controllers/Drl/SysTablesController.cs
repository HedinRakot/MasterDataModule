using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="SysTable"/> entity
    /// </summary>
    public partial class SysTablesController: ClientApiController<SysTableModel, SysTable, int, ISysTableManager>
    {

        public SysTablesController(ISysTableManager manager): base(manager){}

        protected override void EntityToModel(SysTable entity, SysTableModel model)
        {
            model.description = entity.Description;
            model.editMode = entity.EditMode;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(SysTableModel model, SysTable entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.EditMode = model.editMode;
        }
    }
}
