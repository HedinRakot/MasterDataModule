define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsSummaryField'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsSummaryFields',
		model: Model
	});

	return collection;
});
