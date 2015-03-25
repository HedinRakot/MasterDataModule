using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.CommunityParticipant })]
    /// <summary>
    ///     Controller for <see cref="CommunityParticipant"/> entity
    /// </summary>
    public partial class CommunityParticipantsController: ClientApiController<CommunityParticipantModel, CommunityParticipant, int, ICommunityParticipantManager>
    {

        public CommunityParticipantsController(ICommunityParticipantManager manager): base(manager){}

        protected override void EntityToModel(CommunityParticipant entity, CommunityParticipantModel model)
        {
            model.driverSchoolIdParticipant = entity.DriverSchoolIdParticipant;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.driverSchoolIdLead = entity.DriverSchoolIdLead;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(CommunityParticipantModel model, CommunityParticipant entity, ActionTypes actionType)
        {
            entity.DriverSchoolIdParticipant = model.driverSchoolIdParticipant;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.DriverSchoolIdLead = model.driverSchoolIdLead;
        }
    }
}
