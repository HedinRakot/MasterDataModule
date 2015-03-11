define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsNextInspection'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsNextInspections',
		model: Model
	});

	return collection;
});
