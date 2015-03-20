define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'InsNextSpIntervals': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsNextSpIntervals', { productObjectTypes: true, productObjectClasses: true, }),
	            'InsNextSpIntervals/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsNextSpInterval', 'models/TechnicalInspectionMasterData/InsNextSpInterval', { productObjectTypes: true, productObjectClasses: true, }),
	            'InsNextSpIntervals/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsNextSpInterval', 'models/TechnicalInspectionMasterData/InsNextSpInterval', { productObjectTypes: true, productObjectClasses: true, }),
				'InsObdStatuses': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsObdStatuses', { fuelTypes: true, }),
	            'InsObdStatuses/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsObdStatus', 'models/TechnicalInspectionMasterData/InsObdStatus', { fuelTypes: true, }),
	            'InsObdStatuses/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsObdStatus', 'models/TechnicalInspectionMasterData/InsObdStatus', { fuelTypes: true, }),
				'InsOpticalDefects': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsOpticalDefects', false),
	            'InsOpticalDefects/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsOpticalDefect', 'models/TechnicalInspectionMasterData/InsOpticalDefect', false),
	            'InsOpticalDefects/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsOpticalDefect', 'models/TechnicalInspectionMasterData/InsOpticalDefect', false),
				'InsProductClassGroups': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsProductClassGroups', false),
	            'InsProductClassGroups/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsProductClassGroup', 'models/TechnicalInspectionMasterData/InsProductClassGroup', false),
	            'InsProductClassGroups/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsProductClassGroup', 'models/TechnicalInspectionMasterData/InsProductClassGroup', false),
				'InsSeverityTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsSeverityTypes', false),
	            'InsSeverityTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsSeverityType', 'models/TechnicalInspectionMasterData/InsSeverityType', false),
	            'InsSeverityTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsSeverityType', 'models/TechnicalInspectionMasterData/InsSeverityType', false),
				'InsValidPeriods': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsValidPeriods', false),
	            'InsValidPeriods/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsValidPeriod', 'models/TechnicalInspectionMasterData/InsValidPeriod', false),
	            'InsValidPeriods/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsValidPeriod', 'models/TechnicalInspectionMasterData/InsValidPeriod', false),
				'InsPfpPositions': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsPfpPositions', false),
	            'InsPfpPositions/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsPfpPosition', 'models/TechnicalInspectionMasterData/InsPfpPosition', false),
	            'InsPfpPositions/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsPfpPosition', 'models/TechnicalInspectionMasterData/InsPfpPosition', false),
				'InsPfpInspectionTypePfpPositionRsps': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsPfpInspectionTypePfpPositionRsps', { inspectionTypes: true, pfpPositions: true, }),
	            'InsPfpInspectionTypePfpPositionRsps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsPfpInspectionTypePfpPositionRsp', 'models/TechnicalInspectionMasterData/InsPfpInspectionTypePfpPositionRsp', { inspectionTypes: true, pfpPositions: true, }),
	            'InsPfpInspectionTypePfpPositionRsps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsPfpInspectionTypePfpPositionRsp', 'models/TechnicalInspectionMasterData/InsPfpInspectionTypePfpPositionRsp', { inspectionTypes: true, pfpPositions: true, }),
				'InsPfpVehicleTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsPfpVehicleTypes', false),
	            'InsPfpVehicleTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsPfpVehicleType', 'models/TechnicalInspectionMasterData/InsPfpVehicleType', false),
	            'InsPfpVehicleTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsPfpVehicleType', 'models/TechnicalInspectionMasterData/InsPfpVehicleType', false),
				'InsUnitCodes': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsUnitCodes', false),
	            'InsUnitCodes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsUnitCode', 'models/TechnicalInspectionMasterData/InsUnitCode', false),
	            'InsUnitCodes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsUnitCode', 'models/TechnicalInspectionMasterData/InsUnitCode', false),
				'InsInspectionSteps': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsInspectionSteps', false),
	            'InsInspectionSteps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsInspectionStep', 'models/TechnicalInspectionMasterData/InsInspectionStep', false),
	            'InsInspectionSteps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsInspectionStep', 'models/TechnicalInspectionMasterData/InsInspectionStep', false),
				'InsAvailableInspectionSteps': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsAvailableInspectionSteps', { insInspectionStep: true, }),
	            'InsAvailableInspectionSteps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsAvailableInspectionStep', 'models/TechnicalInspectionMasterData/InsAvailableInspectionStep', { insInspectionStep: true, }),
	            'InsAvailableInspectionSteps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsAvailableInspectionStep', 'models/TechnicalInspectionMasterData/InsAvailableInspectionStep', { insInspectionStep: true, }),
				'InsSummaryFields': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsSummaryFields', false),
	            'InsSummaryFields/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsSummaryField', 'models/TechnicalInspectionMasterData/InsSummaryField', false),
	            'InsSummaryFields/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsSummaryField', 'models/TechnicalInspectionMasterData/InsSummaryField', false),
				'InsNextInspections': _.partial(BaseRouter.showView, baseRouter, 'l!t!TechnicalInspectionMasterData/InsNextInspections', false),
	            'InsNextInspections/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsNextInspection', 'models/TechnicalInspectionMasterData/InsNextInspection', false),
	            'InsNextInspections/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!TechnicalInspectionMasterData/AddInsNextInspection', 'models/TechnicalInspectionMasterData/InsNextInspection', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
