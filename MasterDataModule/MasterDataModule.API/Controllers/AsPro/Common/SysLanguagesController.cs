using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="SysLanguage"/> entity
    /// </summary>
    public partial class SysLanguagesController: ClientApiController<SysLanguageModel, SysLanguage, int, ISysLanguageManager>
    {

        public SysLanguagesController(ISysLanguageManager manager): base(manager){}

        protected override void EntityToModel(SysLanguage entity, SysLanguageModel model)
        {
            model.sapId = entity.SapId;
            model.sapIdIso = entity.SapIdIso;
            model.resourceFileName = entity.ResourceFileName;
            model.isAvailable = entity.IsAvailable;
        }
        protected override void ModelToEntity(SysLanguageModel model, SysLanguage entity, ActionTypes actionType)
        {
            entity.SapId = model.sapId;
            entity.SapIdIso = model.sapIdIso;
            entity.ResourceFileName = model.resourceFileName;
            entity.IsAvailable = model.isAvailable;
        }
    }
}