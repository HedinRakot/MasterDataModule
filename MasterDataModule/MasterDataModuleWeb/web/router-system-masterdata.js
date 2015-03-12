define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'SysLanguages': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/SysLanguages'),
	            'SysLanguages/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysLanguage', 'models/CommonMasterData/System/SysLanguage', false),
	            'SysLanguages/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysLanguage', 'models/CommonMasterData/System/SysLanguage', false),
				'SysLocations': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/SysLocations'),
	            'SysLocations/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysLocation', 'models/CommonMasterData/System/SysLocation', false),
	            'SysLocations/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysLocation', 'models/CommonMasterData/System/SysLocation', false),
				'SysRoles': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/SysRoles'),
	            'SysRoles/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysRole', 'models/CommonMasterData/System/SysRole', false),
	            'SysRoles/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysRole', 'models/CommonMasterData/System/SysRole', false),
				'SysRoleSysPermissionRsps': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/SysRoleSysPermissionRsps'),
	            'SysRoleSysPermissionRsps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysRoleSysPermissionRsp', 'models/CommonMasterData/System/SysRoleSysPermissionRsp', false),
	            'SysRoleSysPermissionRsps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysRoleSysPermissionRsp', 'models/CommonMasterData/System/SysRoleSysPermissionRsp', false),
				'OrdFederalGroups': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/OrdFederalGroups'),
	            'OrdFederalGroups/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddOrdFederalGroup', 'models/CommonMasterData/System/OrdFederalGroup', false),
	            'OrdFederalGroups/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddOrdFederalGroup', 'models/CommonMasterData/System/OrdFederalGroup', false),
				'OrdFederalStates': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/OrdFederalStates'),
	            'OrdFederalStates/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddOrdFederalState', 'models/CommonMasterData/System/OrdFederalState', false),
	            'OrdFederalStates/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddOrdFederalState', 'models/CommonMasterData/System/OrdFederalState', false),
				'SysCountries': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/SysCountries'),
	            'SysCountries/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysCountry', 'models/CommonMasterData/System/SysCountry', false),
	            'SysCountries/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysCountry', 'models/CommonMasterData/System/SysCountry', false),
				'SysPostCodes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/SysPostCodes'),
	            'SysPostCodes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysPostCode', 'models/CommonMasterData/System/SysPostCode', false),
	            'SysPostCodes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddSysPostCode', 'models/CommonMasterData/System/SysPostCode', false),
				'OrdOrderCancelationReasons': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/OrdOrderCancelationReasons'),
	            'OrdOrderCancelationReasons/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddOrdOrderCancelationReason', 'models/CommonMasterData/System/OrdOrderCancelationReason', false),
	            'OrdOrderCancelationReasons/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddOrdOrderCancelationReason', 'models/CommonMasterData/System/OrdOrderCancelationReason', false),
				'KssExpenseGrounds': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/KssExpenseGrounds'),
	            'KssExpenseGrounds/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddKssExpenseGround', 'models/CommonMasterData/System/KssExpenseGround', false),
	            'KssExpenseGrounds/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddKssExpenseGround', 'models/CommonMasterData/System/KssExpenseGround', false),
				'ExpPassengersTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/ExpPassengersTypes'),
	            'ExpPassengersTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddExpPassengersType', 'models/CommonMasterData/System/ExpPassengersType', false),
	            'ExpPassengersTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddExpPassengersType', 'models/CommonMasterData/System/ExpPassengersType', false),
				'InsVatTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/System/InsVatTypes'),
	            'InsVatTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddInsVatType', 'models/CommonMasterData/System/InsVatType', false),
	            'InsVatTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/System/AddInsVatType', 'models/CommonMasterData/System/InsVatType', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
