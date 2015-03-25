using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MeetingPointOrganizationalUnit })]
    /// <summary>
    ///     Controller for <see cref="MeetingPointOrganizationalUnit"/> entity
    /// </summary>
    public partial class MeetingPointOrganizationalUnitsController: ClientApiController<MeetingPointOrganizationalUnitModel, MeetingPointOrganizationalUnit, int, IMeetingPointOrganizationalUnitManager>
    {

        public MeetingPointOrganizationalUnitsController(IMeetingPointOrganizationalUnitManager manager): base(manager){}

        protected override void EntityToModel(MeetingPointOrganizationalUnit entity, MeetingPointOrganizationalUnitModel model)
        {
            model.meetingPointId = entity.MeetingPointId;
            model.orgOrganizationalUnitId = entity.OrgOrganizationalUnitId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MeetingPointOrganizationalUnitModel model, MeetingPointOrganizationalUnit entity, ActionTypes actionType)
        {
            entity.MeetingPointId = model.meetingPointId;
            entity.OrgOrganizationalUnitId = model.orgOrganizationalUnitId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
