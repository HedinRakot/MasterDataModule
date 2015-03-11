define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsAvailableInspectionStep'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsAvailableInspectionSteps',
		model: Model
	});

	return collection;
});
