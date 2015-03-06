using TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using System.Collections.Generic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.CommonMasterData
{
    //TODO [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.ExamClasses })]
    public partial class EmpEmployeesController : ClientApiController<EmpEmployeeModel, EmpEmployee, int, IEmpEmployeeManager>
    {
        public EmpEmployeesController(IEmpEmployeeManager empEmployeeManager)
            : base(empEmployeeManager)
        {
        }

        protected override void EntityToModel(EmpEmployee entity, EmpEmployeeModel model)
        {
            model.personalNumber = entity.PersonalNumber;
            model.domain = entity.Domain;
            model.userName = entity.UserName;
            model.windowsUserName = entity.WindowsUserName;
            model.isSSOAllowed = entity.IsSsoAllowed.HasValue ? entity.IsSsoAllowed.Value : false;
            model.isPasswordLoginAllowed = entity.IsPasswordLoginAllowed.HasValue ? entity.IsPasswordLoginAllowed.Value : false;
            model.isEmergencyLoginAllowed = entity.IsEmergencyLoginAllowed.HasValue ? entity.IsEmergencyLoginAllowed.Value : false;
            model.empCoreAddressId = entity.EmpCoreAddressId;
            model.name = entity.Name;
            model.lastName = entity.LastName;
            model.middleName = entity.MiddleName;
            model.comment = entity.Comment;
            model.sexType = entity.SexType.HasValue ? entity.SexType.Value : 0;
            model.title = entity.Title;
            model.birthDate = entity.Birthdate;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }

        protected override void ModelToEntity(EmpEmployeeModel model, EmpEmployee entity, ActionTypes actionType)
        {
            entity.PersonalNumber = model.personalNumber;
            entity.Domain = model.domain;
            entity.UserName = model.userName;
            entity.WindowsUserName = model.windowsUserName;
            entity.IsSsoAllowed = model.isSSOAllowed;
            entity.IsPasswordLoginAllowed = model.isPasswordLoginAllowed;
            entity.IsEmergencyLoginAllowed = model.isEmergencyLoginAllowed;
            entity.EmpCoreAddressId = model.empCoreAddressId;
            entity.Name = model.name;
            entity.LastName = model.lastName;
            entity.MiddleName = model.middleName;
            entity.Comment = model.comment;
            entity.SexType = model.sexType;
            entity.Title = model.title;
            entity.Birthdate = model.birthDate;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}