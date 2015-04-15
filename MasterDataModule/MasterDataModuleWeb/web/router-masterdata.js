define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'MasterDataJobInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataJobInfos', { LogTypeInfo: true, }),
	            'MasterDataJobInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataJobInfo', 'models/Settings/MasterDataJobInfo', { LogTypeInfo: true, }),
	            'MasterDataJobInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataJobInfo', 'models/Settings/MasterDataJobInfo', { LogTypeInfo: true, }),
				'MasterDataJobCheckResults': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataJobCheckResults', false),
	            'MasterDataJobCheckResults/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataJobCheckResults', 'models/Settings/MasterDataJobCheckResults', false),
	            'MasterDataJobCheckResults/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataJobCheckResults', 'models/Settings/MasterDataJobCheckResults', false),
				'MasterDataWindowsServiceInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataWindowsServiceInfos', { LogTypeInfo: true, }),
	            'MasterDataWindowsServiceInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWindowsServiceInfo', 'models/Settings/MasterDataWindowsServiceInfo', { LogTypeInfo: true, }),
	            'MasterDataWindowsServiceInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWindowsServiceInfo', 'models/Settings/MasterDataWindowsServiceInfo', { LogTypeInfo: true, }),
				'MasterDataWindowsServiceCheckResults': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataWindowsServiceCheckResults', false),
	            'MasterDataWindowsServiceCheckResults/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWindowsServiceCheckResults', 'models/Settings/MasterDataWindowsServiceCheckResults', false),
	            'MasterDataWindowsServiceCheckResults/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWindowsServiceCheckResults', 'models/Settings/MasterDataWindowsServiceCheckResults', false),
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
				'MasterDataSubscribers': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataSubscribers', false),
	            'MasterDataSubscribers/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSubscribers', 'models/Settings/MasterDataSubscribers', false),
	            'MasterDataSubscribers/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSubscribers', 'models/Settings/MasterDataSubscribers', false),
				'MasterDataNotifications': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataNotifications', { MasterDataSubscribers: true, NotificationType: true, AlertCheckStatus: true, }),
	            'MasterDataNotifications/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataNotifications', 'models/Settings/MasterDataNotifications', { MasterDataSubscribers: true, NotificationType: true, AlertCheckStatus: true, }),
	            'MasterDataNotifications/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataNotifications', 'models/Settings/MasterDataNotifications', { MasterDataSubscribers: true, NotificationType: true, AlertCheckStatus: true, }),
				'SysColumns': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/SysColumns', false),
	            'SysColumns/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysColumn', 'models/Settings/SysColumn', false),
	            'SysColumns/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysColumn', 'models/Settings/SysColumn', false),
				'MasterDataMonitorableInfoMasterDataNotificationsRsps': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataMonitorableInfoMasterDataNotificationsRsps', { MasterDataNotifications: true, CheckModuleType: true, MasterDataJobInfo: true, MasterDataSiteInfo: true, MasterDataWcfInfo: true, MasterDataWindowsServiceInfo: true, }),
	            'MasterDataMonitorableInfoMasterDataNotificationsRsps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataMonitorableInfoMasterDataNotificationsRsp', 'models/Settings/MasterDataMonitorableInfoMasterDataNotificationsRsp', { MasterDataNotifications: true, CheckModuleType: true, MasterDataJobInfo: true, MasterDataSiteInfo: true, MasterDataWcfInfo: true, MasterDataWindowsServiceInfo: true, }),
	            'MasterDataMonitorableInfoMasterDataNotificationsRsps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataMonitorableInfoMasterDataNotificationsRsp', 'models/Settings/MasterDataMonitorableInfoMasterDataNotificationsRsp', { MasterDataNotifications: true, CheckModuleType: true, MasterDataJobInfo: true, MasterDataSiteInfo: true, MasterDataWcfInfo: true, MasterDataWindowsServiceInfo: true, }),
				'SysTables': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/SysTables', { EditModeType: true, }),
	            'SysTables/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysTable', 'models/Settings/SysTable', { EditModeType: true, }),
	            'SysTables/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysTable', 'models/Settings/SysTable', { EditModeType: true, }),
				'MasterDataNotificationsMasterDataSubscribersRsps': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataNotificationsMasterDataSubscribersRsps', false),
	            'MasterDataNotificationsMasterDataSubscribersRsps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataNotificationsMasterDataSubscribersRsp', 'models/Settings/MasterDataNotificationsMasterDataSubscribersRsp', false),
	            'MasterDataNotificationsMasterDataSubscribersRsps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataNotificationsMasterDataSubscribersRsp', 'models/Settings/MasterDataNotificationsMasterDataSubscribersRsp', false),
				'ApplicationLogs': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/ApplicationLogs', { LogTypeInfos: true, }),
	            'ApplicationLogs/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddApplicationLogs', 'models/Settings/ApplicationLogs', { LogTypeInfos: true, }),
	            'ApplicationLogs/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddApplicationLogs', 'models/Settings/ApplicationLogs', { LogTypeInfos: true, }),
				'MasterDataWcfInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataWcfInfos', { LogTypeInfo: true, }),
	            'MasterDataWcfInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWcfInfo', 'models/Settings/MasterDataWcfInfo', { LogTypeInfo: true, }),
	            'MasterDataWcfInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWcfInfo', 'models/Settings/MasterDataWcfInfo', { LogTypeInfo: true, }),
				'MasterDataWcfCheckResults': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataWcfCheckResults', false),
	            'MasterDataWcfCheckResults/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWcfCheckResults', 'models/Settings/MasterDataWcfCheckResults', false),
	            'MasterDataWcfCheckResults/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWcfCheckResults', 'models/Settings/MasterDataWcfCheckResults', false),
				'MasterDataSiteInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataSiteInfos', { LogTypeInfo: true, }),
	            'MasterDataSiteInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSiteInfo', 'models/Settings/MasterDataSiteInfo', { LogTypeInfo: true, }),
	            'MasterDataSiteInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSiteInfo', 'models/Settings/MasterDataSiteInfo', { LogTypeInfo: true, }),
				'MasterDataSiteCheckResults': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataSiteCheckResults', false),
	            'MasterDataSiteCheckResults/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSiteCheckResults', 'models/Settings/MasterDataSiteCheckResults', false),
	            'MasterDataSiteCheckResults/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSiteCheckResults', 'models/Settings/MasterDataSiteCheckResults', false),
				'LogTypeInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/LogTypeInfos', false),
	            'LogTypeInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddLogTypeInfo', 'models/Settings/LogTypeInfo', false),
	            'LogTypeInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddLogTypeInfo', 'models/Settings/LogTypeInfo', false),
				'MasterDataMonitorStates': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataMonitorStates', false),
	            'MasterDataMonitorStates/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataMonitorState', 'models/Settings/MasterDataMonitorState', false),
	            'MasterDataMonitorStates/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataMonitorState', 'models/Settings/MasterDataMonitorState', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
