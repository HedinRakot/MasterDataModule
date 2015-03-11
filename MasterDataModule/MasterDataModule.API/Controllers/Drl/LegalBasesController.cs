using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="LegalBasis"/> entity
    /// </summary>
    public partial class LegalBasesController: ClientApiController<LegalBasisModel, LegalBasis, int, ILegalBasisManager>
    {

        public LegalBasesController(ILegalBasisManager manager): base(manager){}

        protected override void EntityToModel(LegalBasis entity, LegalBasisModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.educationCertificateRequired = entity.EducationCertificateRequired;
            model.firstAssignation = entity.FirstAssignation;
            model.messageReason = entity.MessageReason;
            model.messageReasonStyle = entity.MessageReasonStyle;
            model.replacementId = entity.ReplacementId;
            model.printName = entity.PrintName;
        }
        protected override void ModelToEntity(LegalBasisModel model, LegalBasis entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.EducationCertificateRequired = model.educationCertificateRequired;
            entity.FirstAssignation = model.firstAssignation;
            entity.MessageReason = model.messageReason;
            entity.MessageReasonStyle = model.messageReasonStyle;
            entity.ReplacementId = model.replacementId;
            entity.PrintName = model.printName;
        }
    }
}
