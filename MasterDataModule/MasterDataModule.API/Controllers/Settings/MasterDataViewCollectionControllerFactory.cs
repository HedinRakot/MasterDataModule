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
            if (model.MasterDataWcfInfo)
            	result.Add("MasterDataWcfInfo", GetViewCollection<MasterDataWcfInfo, int, IMasterDataWcfInfoManager>(
            		(IMasterDataWcfInfoManager)resolver.GetService(typeof(IMasterDataWcfInfoManager))));

            if (model.MasterDataSiteInfo)
            	result.Add("MasterDataSiteInfo", GetViewCollection<MasterDataSiteInfo, int, IMasterDataSiteInfoManager>(
            		(IMasterDataSiteInfoManager)resolver.GetService(typeof(IMasterDataSiteInfoManager))));

            if (model.MasterDataJobInfo)
            	result.Add("MasterDataJobInfo", GetViewCollection<MasterDataJobInfo, int, IMasterDataJobInfoManager>(
            		(IMasterDataJobInfoManager)resolver.GetService(typeof(IMasterDataJobInfoManager))));

            if (model.MasterDataWindowsServiceInfo)
            	result.Add("MasterDataWindowsServiceInfo", GetViewCollection<MasterDataWindowsServiceInfo, int, IMasterDataWindowsServiceInfoManager>(
            		(IMasterDataWindowsServiceInfoManager)resolver.GetService(typeof(IMasterDataWindowsServiceInfoManager))));

            if (model.Role)
            	result.Add("Role", GetViewCollection<Role, int, IRoleManager>(
            		(IRoleManager)resolver.GetService(typeof(IRoleManager))));

            if (model.Permission)
            	result.Add("Permission", GetViewCollection<Permission, int, IPermissionManager>(
            		(IPermissionManager)resolver.GetService(typeof(IPermissionManager))));

            if (model.MasterDataSubscribers)
            	result.Add("MasterDataSubscribers", GetViewCollection<MasterDataSubscribers, int, IMasterDataSubscribersManager>(
            		(IMasterDataSubscribersManager)resolver.GetService(typeof(IMasterDataSubscribersManager))));

            if (model.MasterDataNotifications)
            	result.Add("MasterDataNotifications", GetViewCollection<MasterDataNotifications, int, IMasterDataNotificationsManager>(
            		(IMasterDataNotificationsManager)resolver.GetService(typeof(IMasterDataNotificationsManager))));

            if (model.LogTypeInfo)
            	result.Add("LogTypeInfo", GetViewCollection<LogTypeInfo, int, ILogTypeInfoManager>(
            		(ILogTypeInfoManager)resolver.GetService(typeof(ILogTypeInfoManager))));

        }
    }
}
