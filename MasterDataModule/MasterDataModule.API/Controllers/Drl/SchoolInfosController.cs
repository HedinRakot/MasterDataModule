using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="SchoolInfo"/> entity
    /// </summary>
    public partial class SchoolInfosController: ClientApiController<SchoolInfoModel, SchoolInfo, int, ISchoolInfoManager>
    {

        public SchoolInfosController(ISchoolInfoManager manager): base(manager){}

        protected override void EntityToModel(SchoolInfo entity, SchoolInfoModel model)
        {
            model.text = entity.Text;
        }
        protected override void ModelToEntity(SchoolInfoModel model, SchoolInfo entity, ActionTypes actionType)
        {
            entity.Text = model.text;
        }
    }
}
