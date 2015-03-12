using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="Community"/> entity
    /// </summary>
    public partial class CommunitiesController: ClientApiController<CommunityModel, Community, int, ICommunityManager>
    {

        public CommunitiesController(ICommunityManager manager): base(manager){}

        protected override void EntityToModel(Community entity, CommunityModel model)
        {
            model.driverSchoolId = entity.DriverSchoolId;
        }
        protected override void ModelToEntity(CommunityModel model, Community entity, ActionTypes actionType)
        {
            entity.DriverSchoolId = model.driverSchoolId;
        }
    }
}