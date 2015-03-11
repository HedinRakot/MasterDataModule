define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsSeverityType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsSeverityTypes',
		model: Model
	});

	return collection;
});
