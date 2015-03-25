using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.OrgBankInformation })]
    /// <summary>
    ///     Controller for <see cref="OrgBankInformation"/> entity
    /// </summary>
    public partial class OrgBankInformationController: ClientApiController<OrgBankInformationModel, OrgBankInformation, int, IOrgBankInformationManager>
    {

        public OrgBankInformationController(IOrgBankInformationManager manager): base(manager){}

        protected override void EntityToModel(OrgBankInformation entity, OrgBankInformationModel model)
        {
            model.bankName = entity.BankName;
            model.bankCode = entity.BankCode;
            model.bankAccount = entity.BankAccount;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrgBankInformationModel model, OrgBankInformation entity, ActionTypes actionType)
        {
            entity.BankName = model.bankName;
            entity.BankCode = model.bankCode;
            entity.BankAccount = model.bankAccount;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
