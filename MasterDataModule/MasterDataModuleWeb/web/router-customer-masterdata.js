define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'OrdBillingParameters': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Customer/OrdBillingParameters'),
	            'OrdBillingParameters/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Customer/AddOrdBillingParameter', 'models/CommonMasterData/Customer/OrdBillingParameter', false),
	            'OrdBillingParameters/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Customer/AddOrdBillingParameter', 'models/CommonMasterData/Customer/OrdBillingParameter', false),
				'OrdContactPersonFunctions': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Customer/OrdContactPersonFunctions'),
	            'OrdContactPersonFunctions/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Customer/AddOrdContactPersonFunction', 'models/CommonMasterData/Customer/OrdContactPersonFunction', false),
	            'OrdContactPersonFunctions/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Customer/AddOrdContactPersonFunction', 'models/CommonMasterData/Customer/OrdContactPersonFunction', false),
				'OrdCustomerInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Customer/OrdCustomerInfos'),
	            'OrdCustomerInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Customer/AddOrdCustomerInfo', 'models/CommonMasterData/Customer/OrdCustomerInfo', false),
	            'OrdCustomerInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Customer/AddOrdCustomerInfo', 'models/CommonMasterData/Customer/OrdCustomerInfo', false),
				'OrdPartnerRoles': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Customer/OrdPartnerRoles'),
	            'OrdPartnerRoles/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Customer/AddOrdPartnerRole', 'models/CommonMasterData/Customer/OrdPartnerRole', false),
	            'OrdPartnerRoles/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Customer/AddOrdPartnerRole', 'models/CommonMasterData/Customer/OrdPartnerRole', false),
				'InsTaxClasses': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Customer/InsTaxClasses'),
	            'InsTaxClasses/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Customer/AddInsTaxClass', 'models/CommonMasterData/Customer/InsTaxClass', false),
	            'InsTaxClasses/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Customer/AddInsTaxClass', 'models/CommonMasterData/Customer/InsTaxClass', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
