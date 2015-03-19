using MasterDataModule.API.Controllers;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     CommonViewCollectionControllerFactory class
    /// </summary>
    public class CommonViewCollectionControllerFactory: ViewCollectionControllerFactoryBase
    {
        public void GetViewCollections(IDependencyResolver resolver, CollectionTypesModel model, Dictionary<string, IEnumerable<object>> result)
        {
            if (model.SysLanguage)
            	result.Add("SysLanguage", GetViewCollection<SysLanguage, int, ISysLanguageManager>(
            		(ISysLanguageManager)resolver.GetService(typeof(ISysLanguageManager))));

        }
    }
}
