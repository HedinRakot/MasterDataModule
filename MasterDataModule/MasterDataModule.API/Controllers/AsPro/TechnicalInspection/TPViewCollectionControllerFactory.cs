using MasterDataModule.API.Controllers;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     TPViewCollectionControllerFactory class
    /// </summary>
    public class TPViewCollectionControllerFactory: ViewCollectionControllerFactoryBase
    {
        public void GetViewCollections(IDependencyResolver resolver, CollectionTypesModel model, Dictionary<string, IEnumerable<object>> result)
        {
        }
    }
}
