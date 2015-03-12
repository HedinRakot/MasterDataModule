define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'InsNextSpIntervals': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsNextSpIntervals'),
	            'InsNextSpIntervals/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsNextSpInterval', 'models/TechnicalInspectionMasterData/InsNextSpInterval', false),
	            'InsNextSpIntervals/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsNextSpInterval', 'models/TechnicalInspectionMasterData/InsNextSpInterval', false),
				'InsObdStatuses': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsObdStatuses'),
	            'InsObdStatuses/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsObdStatus', 'models/TechnicalInspectionMasterData/InsObdStatus', false),
	            'InsObdStatuses/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsObdStatus', 'models/TechnicalInspectionMasterData/InsObdStatus', false),
				'InsOpticalDefects': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsOpticalDefects'),
	            'InsOpticalDefects/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsOpticalDefect', 'models/TechnicalInspectionMasterData/InsOpticalDefect', false),
	            'InsOpticalDefects/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsOpticalDefect', 'models/TechnicalInspectionMasterData/InsOpticalDefect', false),
				'InsProductClassGroups': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsProductClassGroups'),
	            'InsProductClassGroups/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsProductClassGroup', 'models/TechnicalInspectionMasterData/InsProductClassGroup', false),
	            'InsProductClassGroups/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsProductClassGroup', 'models/TechnicalInspectionMasterData/InsProductClassGroup', false),
				'InsSeverityTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsSeverityTypes'),
	            'InsSeverityTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsSeverityType', 'models/TechnicalInspectionMasterData/InsSeverityType', false),
	            'InsSeverityTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsSeverityType', 'models/TechnicalInspectionMasterData/InsSeverityType', false),
				'InsValidPeriods': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsValidPeriods'),
	            'InsValidPeriods/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsValidPeriod', 'models/TechnicalInspectionMasterData/InsValidPeriod', false),
	            'InsValidPeriods/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsValidPeriod', 'models/TechnicalInspectionMasterData/InsValidPeriod', false),
				'InsPfpPositions': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsPfpPositions'),
	            'InsPfpPositions/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsPfpPosition', 'models/TechnicalInspectionMasterData/InsPfpPosition', false),
	            'InsPfpPositions/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsPfpPosition', 'models/TechnicalInspectionMasterData/InsPfpPosition', false),
				'InsPfpVehicleTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsPfpVehicleTypes'),
	            'InsPfpVehicleTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsPfpVehicleType', 'models/TechnicalInspectionMasterData/InsPfpVehicleType', false),
	            'InsPfpVehicleTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsPfpVehicleType', 'models/TechnicalInspectionMasterData/InsPfpVehicleType', false),
				'InsUnitCodes': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsUnitCodes'),
	            'InsUnitCodes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsUnitCode', 'models/TechnicalInspectionMasterData/InsUnitCode', false),
	            'InsUnitCodes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsUnitCode', 'models/TechnicalInspectionMasterData/InsUnitCode', false),
				'InsInspectionSteps': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsInspectionSteps'),
	            'InsInspectionSteps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsInspectionStep', 'models/TechnicalInspectionMasterData/InsInspectionStep', false),
	            'InsInspectionSteps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsInspectionStep', 'models/TechnicalInspectionMasterData/InsInspectionStep', false),
				'InsAvailableInspectionSteps': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsAvailableInspectionSteps'),
	            'InsAvailableInspectionSteps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsAvailableInspectionStep', 'models/TechnicalInspectionMasterData/InsAvailableInspectionStep', false),
	            'InsAvailableInspectionSteps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsAvailableInspectionStep', 'models/TechnicalInspectionMasterData/InsAvailableInspectionStep', false),
				'InsSummaryFields': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsSummaryFields'),
	            'InsSummaryFields/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsSummaryField', 'models/TechnicalInspectionMasterData/InsSummaryField', false),
	            'InsSummaryFields/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsSummaryField', 'models/TechnicalInspectionMasterData/InsSummaryField', false),
				'InsNextInspections': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsNextInspections'),
	            'InsNextInspections/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsNextInspection', 'models/TechnicalInspectionMasterData/InsNextInspection', false),
	            'InsNextInspections/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsNextInspection', 'models/TechnicalInspectionMasterData/InsNextInspection', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
