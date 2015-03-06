using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    //TODO [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.ExamClasses })]
    public partial class LegalBasisesController : ClientApiController<LegalBasisModel, LegalBasis, int, ILegalBasisManager>
    {
        public LegalBasisesController(ILegalBasisManager legalBasisManager)
            : base(legalBasisManager)
        {
        }

        protected override void EntityToModel(LegalBasis entity, LegalBasisModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.isAttestationRequired = entity.EducationCertificateRequired;
            model.messageReason = entity.MessageReason;
            model.messageReasonStyle = entity.MessageReasonStyle;
            model.printName = entity.PrintName;
            model.replacementId = entity.ReplacementId;
            model.isFirstAssignation = (int)entity.FirstAssignation;
        }

        protected override void ModelToEntity(LegalBasisModel model, LegalBasis entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = string.IsNullOrWhiteSpace(model.description) ? string.Empty : model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.EducationCertificateRequired = model.isAttestationRequired;
            entity.MessageReason = model.messageReason;
            entity.MessageReasonStyle = model.messageReasonStyle;
            entity.PrintName = model.printName;
            entity.ReplacementId = model.replacementId;
            entity.FirstAssignation = (Assignation)model.isFirstAssignation;
        }
    }
}