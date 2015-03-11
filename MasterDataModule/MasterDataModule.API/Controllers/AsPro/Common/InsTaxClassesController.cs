using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsTaxClass"/> entity
    /// </summary>
    public partial class InsTaxClassesController: ClientApiController<InsTaxClassModel, InsTaxClass, int, IInsTaxClassManager>
    {

        public InsTaxClassesController(IInsTaxClassManager manager): base(manager){}

        protected override void EntityToModel(InsTaxClass entity, InsTaxClassModel model)
        {
            model.taxClass = entity.TaxClass;
        }
        protected override void ModelToEntity(InsTaxClassModel model, InsTaxClass entity, ActionTypes actionType)
        {
            entity.TaxClass = model.taxClass;
        }
    }
}
