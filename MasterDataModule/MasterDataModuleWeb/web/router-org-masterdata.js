define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'OrgAccountTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Org/OrgAccountTypes'),
	            'OrgAccountTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgAccountType', 'models/CommonMasterData/Org/OrgAccountType', false),
	            'OrgAccountTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgAccountType', 'models/CommonMasterData/Org/OrgAccountType', false),
				'OrgAccountingAreas': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Org/OrgAccountingAreas'),
	            'OrgAccountingAreas/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgAccountingArea', 'models/CommonMasterData/Org/OrgAccountingArea', false),
	            'OrgAccountingAreas/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgAccountingArea', 'models/CommonMasterData/Org/OrgAccountingArea', false),
				'OrgBankInformation': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Org/OrgBankInformation'),
	            'OrgBankInformation/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgBankInformation', 'models/CommonMasterData/Org/OrgBankInformation', false),
	            'OrgBankInformation/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgBankInformation', 'models/CommonMasterData/Org/OrgBankInformation', false),
				'OrgCostCenters': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Org/OrgCostCenters'),
	            'OrgCostCenters/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgCostCenter', 'models/CommonMasterData/Org/OrgCostCenter', false),
	            'OrgCostCenters/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgCostCenter', 'models/CommonMasterData/Org/OrgCostCenter', false),
				'OrgCostCenterPrices': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Org/OrgCostCenterPrices'),
	            'OrgCostCenterPrices/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgCostCenterPrice', 'models/CommonMasterData/Org/OrgCostCenterPrice', false),
	            'OrgCostCenterPrices/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgCostCenterPrice', 'models/CommonMasterData/Org/OrgCostCenterPrice', false),
				'OrgRelationshipTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Org/OrgRelationshipTypes'),
	            'OrgRelationshipTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgRelationshipType', 'models/CommonMasterData/Org/OrgRelationshipType', false),
	            'OrgRelationshipTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgRelationshipType', 'models/CommonMasterData/Org/OrgRelationshipType', false),
				'OrgInformation': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Org/OrgInformation'),
	            'OrgInformation/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgInformation', 'models/CommonMasterData/Org/OrgInformation', false),
	            'OrgInformation/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgInformation', 'models/CommonMasterData/Org/OrgInformation', false),
				'OrgTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Org/OrgTypes'),
	            'OrgTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgType', 'models/CommonMasterData/Org/OrgType', false),
	            'OrgTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgType', 'models/CommonMasterData/Org/OrgType', false),
				'OrgInspectionDevices': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Org/OrgInspectionDevices'),
	            'OrgInspectionDevices/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgInspectionDevice', 'models/CommonMasterData/Org/OrgInspectionDevice', false),
	            'OrgInspectionDevices/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Org/AddOrgInspectionDevice', 'models/CommonMasterData/Org/OrgInspectionDevice', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
