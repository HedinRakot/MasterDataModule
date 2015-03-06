//using TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings;
//using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
//using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
//using TuevSued.V1.IT.FE.MasterDataModule.Lib;
//using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data;
//using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data.Enums;
//using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers;
//using System;
//using System.Linq;
//using System.Web.Http;
//using TuevSued.V1.IT.FE.WebBase.Controllers;

//namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.Settings
//{
//    [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.SystemLog })]
//    public class SystemLogController : ReadOnlyClientBaseController<SystemLogRecordModel, SystemLogRecord, SystemLogManager>
//    {
//        protected override void EntityToModel(SystemLogRecord entity, SystemLogRecordModel model)
//        {
//            model.date = entity.Date;
//            model.description = entity.Description;
//            model.userLogin = entity.UserLogin;
//        }				
//    }
//}