using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="EmpEmployee"/> entity
    /// </summary>
    public partial class EmpEmployeesController: ClientApiController<EmpEmployeeModel, EmpEmployee, int, IEmpEmployeeManager>
    {

        public EmpEmployeesController(IEmpEmployeeManager manager): base(manager){}

        protected override void EntityToModel(EmpEmployee entity, EmpEmployeeModel model)
        {
            model.personalNumber = entity.PersonalNumber;
            model.domain = entity.Domain;
            model.userName = entity.UserName;
            model.windowsUserName = entity.WindowsUserName;
            model.isSsoAllowed = entity.IsSsoAllowed;
            model.isEmergencyLoginAllowed = entity.IsEmergencyLoginAllowed;
            model.name = entity.Name;
            model.middleName = entity.MiddleName;
            model.lastName = entity.LastName;
            model.comment = entity.Comment;
            model.sexType = entity.SexType;
            model.title = entity.Title;
            model.birthdate = entity.Birthdate;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(EmpEmployeeModel model, EmpEmployee entity, ActionTypes actionType)
        {
            entity.PersonalNumber = model.personalNumber;
            entity.Domain = model.domain;
            entity.UserName = model.userName;
            entity.WindowsUserName = model.windowsUserName;
            entity.IsSsoAllowed = model.isSsoAllowed;
            entity.IsEmergencyLoginAllowed = model.isEmergencyLoginAllowed;
            entity.Name = model.name;
            entity.MiddleName = model.middleName;
            entity.LastName = model.lastName;
            entity.Comment = model.comment;
            entity.SexType = model.sexType;
            entity.Title = model.title;
            entity.Birthdate = model.birthdate;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
