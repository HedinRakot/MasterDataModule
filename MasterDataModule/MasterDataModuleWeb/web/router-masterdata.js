define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'MasterDataWcfInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataWcfInfos', false),
	            'MasterDataWcfInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWcfInfo', 'models/Settings/MasterDataWcfInfo', false),
	            'MasterDataWcfInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWcfInfo', 'models/Settings/MasterDataWcfInfo', false),
				'MasterDataWcfCheckResults': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataWcfCheckResults', false),
	            'MasterDataWcfCheckResults/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWcfCheckResults', 'models/Settings/MasterDataWcfCheckResults', false),
	            'MasterDataWcfCheckResults/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWcfCheckResults', 'models/Settings/MasterDataWcfCheckResults', false),
				'MasterDataSiteInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataSiteInfos', false),
	            'MasterDataSiteInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSiteInfo', 'models/Settings/MasterDataSiteInfo', false),
	            'MasterDataSiteInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSiteInfo', 'models/Settings/MasterDataSiteInfo', false),
				'MasterDataSiteCheckResults': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataSiteCheckResults', false),
	            'MasterDataSiteCheckResults/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSiteCheckResults', 'models/Settings/MasterDataSiteCheckResults', false),
	            'MasterDataSiteCheckResults/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSiteCheckResults', 'models/Settings/MasterDataSiteCheckResults', false),
				'SysColumns': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/SysColumns', false),
	            'SysColumns/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysColumn', 'models/Settings/SysColumn', false),
	            'SysColumns/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysColumn', 'models/Settings/SysColumn', false),
				'MasterDataMonitorStates': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataMonitorStates', false),
	            'MasterDataMonitorStates/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataMonitorState', 'models/Settings/MasterDataMonitorState', false),
	            'MasterDataMonitorStates/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataMonitorState', 'models/Settings/MasterDataMonitorState', false),
				'MasterDataJobInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataJobInfos', false),
	            'MasterDataJobInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataJobInfo', 'models/Settings/MasterDataJobInfo', false),
	            'MasterDataJobInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataJobInfo', 'models/Settings/MasterDataJobInfo', false),
				'SysTables': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/SysTables', { EditModeType: true, }),
	            'SysTables/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysTable', 'models/Settings/SysTable', { EditModeType: true, }),
	            'SysTables/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddSysTable', 'models/Settings/SysTable', { EditModeType: true, }),
				'MasterDataJobCheckResults': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataJobCheckResults', false),
	            'MasterDataJobCheckResults/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataJobCheckResults', 'models/Settings/MasterDataJobCheckResults', false),
	            'MasterDataJobCheckResults/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataJobCheckResults', 'models/Settings/MasterDataJobCheckResults', false),
				'MasterDataWindowsServiceInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataWindowsServiceInfos', false),
	            'MasterDataWindowsServiceInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWindowsServiceInfo', 'models/Settings/MasterDataWindowsServiceInfo', false),
	            'MasterDataWindowsServiceInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataWindowsServiceInfo', 'models/Settings/MasterDataWindowsServiceInfo', false),
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
				'ApplicationLogs': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/ApplicationLogs', false),
	            'ApplicationLogs/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddApplicationLogs', 'models/Settings/ApplicationLogs', false),
	            'ApplicationLogs/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddApplicationLogs', 'models/Settings/ApplicationLogs', false),
				'MasterDataSubscribers': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataSubscribers', false),
	            'MasterDataSubscribers/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSubscribers', 'models/Settings/MasterDataSubscribers', false),
	            'MasterDataSubscribers/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataSubscribers', 'models/Settings/MasterDataSubscribers', false),
				'MasterDataNotifications': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataNotifications', { MasterDataSubscribers: true, NotificationType: true, AlertCheckStatus: true, }),
	            'MasterDataNotifications/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataNotifications', 'models/Settings/MasterDataNotifications', { MasterDataSubscribers: true, NotificationType: true, AlertCheckStatus: true, }),
	            'MasterDataNotifications/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataNotifications', 'models/Settings/MasterDataNotifications', { MasterDataSubscribers: true, NotificationType: true, AlertCheckStatus: true, }),
				'MasterDataMonitorableInfoMasterDataNotificationsRsps': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataMonitorableInfoMasterDataNotificationsRsps', { MasterDataNotifications: true, CheckModuleType: true, MasterDataJobInfo: true, MasterDataSiteInfo: true, MasterDataWcfInfo: true, MasterDataWindowsServiceInfo: true, }),
	            'MasterDataMonitorableInfoMasterDataNotificationsRsps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataMonitorableInfoMasterDataNotificationsRsp', 'models/Settings/MasterDataMonitorableInfoMasterDataNotificationsRsp', { MasterDataNotifications: true, CheckModuleType: true, MasterDataJobInfo: true, MasterDataSiteInfo: true, MasterDataWcfInfo: true, MasterDataWindowsServiceInfo: true, }),
	            'MasterDataMonitorableInfoMasterDataNotificationsRsps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataMonitorableInfoMasterDataNotificationsRsp', 'models/Settings/MasterDataMonitorableInfoMasterDataNotificationsRsp', { MasterDataNotifications: true, CheckModuleType: true, MasterDataJobInfo: true, MasterDataSiteInfo: true, MasterDataWcfInfo: true, MasterDataWindowsServiceInfo: true, }),
				'MasterDataNotificationsMasterDataSubscribersRsps': _.partial(BaseRouter.showView, baseRouter, 'l!t!Settings/MasterDataNotificationsMasterDataSubscribersRsps', false),
	            'MasterDataNotificationsMasterDataSubscribersRsps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataNotificationsMasterDataSubscribersRsp', 'models/Settings/MasterDataNotificationsMasterDataSubscribersRsp', false),
	            'MasterDataNotificationsMasterDataSubscribersRsps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!Settings/AddMasterDataNotificationsMasterDataSubscribersRsp', 'models/Settings/MasterDataNotificationsMasterDataSubscribersRsp', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
