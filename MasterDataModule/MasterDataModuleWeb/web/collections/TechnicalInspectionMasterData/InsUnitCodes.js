define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsUnitCode'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsUnitCodes',
		model: Model
	});

	return collection;
});
