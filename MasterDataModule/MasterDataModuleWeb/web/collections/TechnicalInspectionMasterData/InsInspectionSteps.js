define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsInspectionStep'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsInspectionSteps',
		model: Model
	});

	return collection;
});
