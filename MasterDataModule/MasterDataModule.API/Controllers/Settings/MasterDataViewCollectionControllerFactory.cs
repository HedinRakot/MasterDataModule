using MasterDataModule.API.Controllers;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Configuration;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     MasterDataViewCollectionControllerFactory class
    /// </summary>
    public class MasterDataViewCollectionControllerFactory: ViewCollectionControllerFactoryBase
    {
        public void GetViewCollections(IDependencyResolver resolver, CollectionTypesModel model, Dictionary<string, IEnumerable<object>> result)
        {
            if (model.Role)
            	result.Add("Role", GetViewCollection<Role, int, IRoleManager>(
            		(IRoleManager)resolver.GetService(typeof(IRoleManager))));

            if (model.Permission)
            	result.Add("Permission", GetViewCollection<Permission, int, IPermissionManager>(
            		(IPermissionManager)resolver.GetService(typeof(IPermissionManager))));

        }
    }
}
