define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsValidPeriod'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsValidPeriods',
		model: Model
	});

	return collection;
});
