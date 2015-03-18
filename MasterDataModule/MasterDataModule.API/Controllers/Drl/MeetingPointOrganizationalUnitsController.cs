using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
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
            model.createDate = entity.CreateDate;
            model.changeDate = entity.ChangeDate;
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
