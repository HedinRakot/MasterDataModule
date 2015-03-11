define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsPfpPosition'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsPfpPositions',
		model: Model
	});

	return collection;
});
