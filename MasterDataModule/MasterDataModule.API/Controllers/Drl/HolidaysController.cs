using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.Holiday })]
    /// <summary>
    ///     Controller for <see cref="Holiday"/> entity
    /// </summary>
    public partial class HolidaysController: ClientApiController<HolidayModel, Holiday, int, IHolidayManager>
    {

        public HolidaysController(IHolidayManager manager): base(manager){}

        protected override void EntityToModel(Holiday entity, HolidayModel model)
        {
            model.name = entity.Name;
            model.date = entity.Date;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(HolidayModel model, Holiday entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Date = model.date;
        }
    }
}
