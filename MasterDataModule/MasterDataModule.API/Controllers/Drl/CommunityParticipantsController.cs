using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
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
