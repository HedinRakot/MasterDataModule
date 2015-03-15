define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'InsCoreDataProductGroups': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/InsCoreDataProductGroups'),
	            'InsCoreDataProductGroups/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsCoreDataProductGroup', 'models/CommonMasterData/Product/InsCoreDataProductGroup', false),
	            'InsCoreDataProductGroups/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsCoreDataProductGroup', 'models/CommonMasterData/Product/InsCoreDataProductGroup', false),
				'InsProductCombinationTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/InsProductCombinationTypes'),
	            'InsProductCombinationTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsProductCombinationType', 'models/CommonMasterData/Product/InsProductCombinationType', false),
	            'InsProductCombinationTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsProductCombinationType', 'models/CommonMasterData/Product/InsProductCombinationType', false),
				'InsProductMaterialGroups': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/InsProductMaterialGroups'),
	            'InsProductMaterialGroups/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsProductMaterialGroup', 'models/CommonMasterData/Product/InsProductMaterialGroup', false),
	            'InsProductMaterialGroups/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsProductMaterialGroup', 'models/CommonMasterData/Product/InsProductMaterialGroup', false),
				'InsProductObjectClasses': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/InsProductObjectClasses'),
	            'InsProductObjectClasses/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsProductObjectClass', 'models/CommonMasterData/Product/InsProductObjectClass', false),
	            'InsProductObjectClasses/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsProductObjectClass', 'models/CommonMasterData/Product/InsProductObjectClass', false),
				'InsProductObjectTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/InsProductObjectTypes'),
	            'InsProductObjectTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsProductObjectType', 'models/CommonMasterData/Product/InsProductObjectType', false),
	            'InsProductObjectTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsProductObjectType', 'models/CommonMasterData/Product/InsProductObjectType', false),
				'InsProductTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/InsProductTypes'),
	            'InsProductTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsProductType', 'models/CommonMasterData/Product/InsProductType', false),
	            'InsProductTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsProductType', 'models/CommonMasterData/Product/InsProductType', false),
				'InsStatisticGroups': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/InsStatisticGroups'),
	            'InsStatisticGroups/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsStatisticGroup', 'models/CommonMasterData/Product/InsStatisticGroup', false),
	            'InsStatisticGroups/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsStatisticGroup', 'models/CommonMasterData/Product/InsStatisticGroup', false),
				'OrdRecognitionTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/OrdRecognitionTypes'),
	            'OrdRecognitionTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddOrdRecognitionType', 'models/CommonMasterData/Product/OrdRecognitionType', false),
	            'OrdRecognitionTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddOrdRecognitionType', 'models/CommonMasterData/Product/OrdRecognitionType', false),
				'OrdRecognitions': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/OrdRecognitions'),
	            'OrdRecognitions/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddOrdRecognition', 'models/CommonMasterData/Product/OrdRecognition', false),
	            'OrdRecognitions/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddOrdRecognition', 'models/CommonMasterData/Product/OrdRecognition', false),
				'OrdRecognitionAreaOfWorkRsps': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/OrdRecognitionAreaOfWorkRsps'),
	            'OrdRecognitionAreaOfWorkRsps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddOrdRecognitionAreaOfWorkRsp', 'models/CommonMasterData/Product/OrdRecognitionAreaOfWorkRsp', false),
	            'OrdRecognitionAreaOfWorkRsps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddOrdRecognitionAreaOfWorkRsp', 'models/CommonMasterData/Product/OrdRecognitionAreaOfWorkRsp', false),
				'InsTaxCodes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Product/InsTaxCodes'),
	            'InsTaxCodes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsTaxCode', 'models/CommonMasterData/Product/InsTaxCode', false),
	            'InsTaxCodes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Product/AddInsTaxCode', 'models/CommonMasterData/Product/InsTaxCode', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
