using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http.Dependencies;
using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MasterDataModule.API
{
    public static partial class JsonHelper
    {
        //TODO Need to be removed
        public static string GetCurrentUserJson(IDependencyResolver resolver)
        {
            var result = new LoggedUserModel();
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
                result.IsAuthenticated = false;
            else
            {
                var userManager = resolver.GetService<IUserManager>();
                var permissionsRspManager = resolver.GetService<IMasterDataRolePermissionRspManager>();
                var permissionsManager = resolver.GetService<IPermissionManager>();

                var user = userManager.GetByLogin(HttpContext.Current.User.Identity.Name);

                result.IsAuthenticated = true;
                result.Name = user.Name;
                var permissionsQuery = from permissionRsp in permissionsRspManager.GetEntities()
                    join permission in permissionsManager.GetEntities() on permissionRsp.MasterDataPermissionId equals permission.Id
                    where permissionRsp.MasterDataRoleId == user.MasterDataRoleId
                    select permission.Name;
                result.Permissions = permissionsQuery.ToList();
            }

            return JsonConvert.SerializeObject(result, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        }

        //TODO Need to be removed
        public static void SetCurrentCulture()
        {
        }

        private static readonly Lazy<Dictionary<string, TableMapping>> TableMappings = new Lazy<Dictionary<string, TableMapping>>(LoadTableMappings, LazyThreadSafetyMode.ExecutionAndPublication);
        private static Dictionary<string, TableMapping> LoadTableMappings()
        {
            var mappings = new Dictionary<string, TableMapping>();

            //TODO UNCOMMENT!!!!
            //DrlTableMappings(mappings);
            //AsProCommonTableMappings(mappings);
            //AsProTPTableMappings(mappings);

            return mappings;
        }

        //TODO Need to be removed
        public static string GetSystemTablesJson(IDependencyResolver resolver)
        {
            //driver licence master data
            

            
            //FeMasterDataColumnsMapping(columnsMappingNames);
            //CommonMasterDataColumnsMapping(columnsMappingNames);


            //TODO another fields

            var service = (ISysTableManager)resolver.GetService(typeof(ISysTableManager));
            var tables = service.GetEntities().ToList();

            var result = new GlobalSysTableModel
            {
                TableNames = new Dictionary<string, SysTableWithColumnsModel>()
            };

            foreach (var item in tables)
            {
                TableMapping tableMapping;
                if (!TableMappings.Value.TryGetValue(item.Name, out tableMapping))
                {
                    continue;
                }
                var dbColumns = item.SysColumns.Where(o => !o.DeleteDate.HasValue && o.ReadOnly).
                    Select(o => o.Name).ToList();


                var tableColumns = tableMapping.Where(o => dbColumns.Contains(o.Key));

                var model = new SysTableWithColumnsModel
                {
                    EditMode = item.EditMode,
                    ReadOnlyColumns = tableColumns.Select(o => o.Value.CodeName).ToList()
                };
                result.TableNames.Add(tableMapping.CodeName, model);
            }
            return JsonConvert.SerializeObject(result, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        }
    }
}
