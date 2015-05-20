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

            if (model.SysLocation)
            	result.Add("SysLocation", GetViewCollection<SysLocation, int, ISysLocationManager>(
            		(ISysLocationManager)resolver.GetService(typeof(ISysLocationManager))));

            if (model.OrgAccountingArea)
            	result.Add("OrgAccountingArea", GetViewCollection<OrgAccountingArea, int, IOrgAccountingAreaManager>(
            		(IOrgAccountingAreaManager)resolver.GetService(typeof(IOrgAccountingAreaManager))));

            if (model.OrdFederalState)
            	result.Add("OrdFederalState", GetViewCollection<OrdFederalState, int, IOrdFederalStateManager>(
            		(IOrdFederalStateManager)resolver.GetService(typeof(IOrdFederalStateManager))));

            if (model.SysCountry)
            	result.Add("SysCountry", GetViewCollection<SysCountry, int, ISysCountryManager>(
            		(ISysCountryManager)resolver.GetService(typeof(ISysCountryManager))));

            if (model.OrgType)
            	result.Add("OrgType", GetViewCollection<OrgType, int, IOrgTypeManager>(
            		(IOrgTypeManager)resolver.GetService(typeof(IOrgTypeManager))));

            if (model.OrgOrganizationalUnit)
            	result.Add("OrgOrganizationalUnit", GetViewCollection<OrgOrganizationalUnit, int, IOrgOrganizationalUnitManager>(
            		(IOrgOrganizationalUnitManager)resolver.GetService(typeof(IOrgOrganizationalUnitManager))));

        }
    }
}
