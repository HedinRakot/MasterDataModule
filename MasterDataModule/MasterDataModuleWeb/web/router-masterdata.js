define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'SysColumns': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/SysColumns', false),
	            'SysColumns/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysColumn', 'models/Settings/SysColumn', false),
	            'SysColumns/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysColumn', 'models/Settings/SysColumn', false),
				'SysTables': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/SysTables', { EditModeType: true, }),
	            'SysTables/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysTable', 'models/Settings/SysTable', { EditModeType: true, }),
	            'SysTables/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysTable', 'models/Settings/SysTable', { EditModeType: true, }),
				'Roles': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/Roles', { Permission: true, Role: true, }),
	            'Roles/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddRole', 'models/Settings/Role', { Permission: true, Role: true, }),
	            'Roles/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddRole', 'models/Settings/Role', { Permission: true, Role: true, }),
				'Permissions': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/Permissions', false),
	            'Permissions/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddPermission', 'models/Settings/Permission', false),
	            'Permissions/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddPermission', 'models/Settings/Permission', false),
				'MasterDataRolePermissionRsps': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataRolePermissionRsps', { Permission: true, Role: true, }),
	            'MasterDataRolePermissionRsps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataRolePermissionRsp', 'models/Settings/MasterDataRolePermissionRsp', { Permission: true, Role: true, }),
	            'MasterDataRolePermissionRsps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataRolePermissionRsp', 'models/Settings/MasterDataRolePermissionRsp', { Permission: true, Role: true, }),
				'Users': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/Users', { Role: true, }),
	            'Users/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddUser', 'models/Settings/User', { Role: true, }),
	            'Users/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddUser', 'models/Settings/User', { Role: true, }),
				'MasterDataSiteInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataSiteInfos', false),
	            'MasterDataSiteInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSiteInfo', 'models/Settings/MasterDataSiteInfo', false),
	            'MasterDataSiteInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSiteInfo', 'models/Settings/MasterDataSiteInfo', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
