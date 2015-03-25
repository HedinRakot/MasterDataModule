using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.ExamRoom })]
    /// <summary>
    ///     Controller for <see cref="ExamRoom"/> entity
    /// </summary>
    public partial class ExamRoomsController: ClientApiController<ExamRoomModel, ExamRoom, int, IExamRoomManager>
    {

        public ExamRoomsController(IExamRoomManager manager): base(manager){}

        protected override void EntityToModel(ExamRoom entity, ExamRoomModel model)
        {
            model.roomNumber = entity.RoomNumber;
            model.placeAmount = entity.PlaceAmount;
            model.orgOrganizationalUnitId = entity.OrgOrganizationalUnitId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.name1 = entity.Name1;
            model.name2 = entity.Name2;
            model.name3 = entity.Name3;
            model.streetHouseNumber = entity.StreetHouseNumber;
            model.zipCode = entity.ZipCode;
            model.zipBox = entity.ZipBox;
            model.box = entity.Box;
            model.city = entity.City;
            model.phone1 = entity.Phone1;
            model.fax = entity.Fax;
            model.email = entity.Email;
            model.sysCountryId = entity.SysCountryId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(ExamRoomModel model, ExamRoom entity, ActionTypes actionType)
        {
            entity.RoomNumber = model.roomNumber;
            entity.PlaceAmount = model.placeAmount;
            entity.OrgOrganizationalUnitId = model.orgOrganizationalUnitId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.Name1 = model.name1;
            entity.Name2 = model.name2;
            entity.Name3 = model.name3;
            entity.StreetHouseNumber = model.streetHouseNumber;
            entity.ZipCode = model.zipCode;
            entity.ZipBox = model.zipBox;
            entity.Box = model.box;
            entity.City = model.city;
            entity.Phone1 = model.phone1;
            entity.Fax = model.fax;
            entity.Email = model.email;
            entity.SysCountryId = model.sysCountryId;
        }
    }
}
