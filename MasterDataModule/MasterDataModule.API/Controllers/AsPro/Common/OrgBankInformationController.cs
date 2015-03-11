using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
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
        }
        protected override void ModelToEntity(OrgBankInformationModel model, OrgBankInformation entity, ActionTypes actionType)
        {
            entity.BankName = model.bankName;
            entity.BankCode = model.bankCode;
            entity.BankAccount = model.bankAccount;
        }
    }
}
