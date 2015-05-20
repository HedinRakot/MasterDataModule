using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.SchoolInfo })]
    /// <summary>
    ///     Controller for <see cref="SchoolInfo"/> entity
    /// </summary>
    public partial class SchoolInfosController: ClientApiController<SchoolInfoModel, SchoolInfo, int, ISchoolInfoManager>
    {

        public SchoolInfosController(ISchoolInfoManager manager): base(manager){}

        protected override void EntityToModel(SchoolInfo entity, SchoolInfoModel model)
        {
            model.description = entity.Description;
            model.text = entity.Text;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(SchoolInfoModel model, SchoolInfo entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.Text = model.text;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
