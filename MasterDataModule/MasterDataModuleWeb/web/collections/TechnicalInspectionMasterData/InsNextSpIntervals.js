define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsNextSpInterval'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsNextSpIntervals',
		model: Model
	});

	return collection;
});
