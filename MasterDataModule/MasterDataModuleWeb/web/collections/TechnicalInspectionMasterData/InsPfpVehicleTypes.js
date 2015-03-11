define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsPfpVehicleType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsPfpVehicleTypes',
		model: Model
	});

	return collection;
});
