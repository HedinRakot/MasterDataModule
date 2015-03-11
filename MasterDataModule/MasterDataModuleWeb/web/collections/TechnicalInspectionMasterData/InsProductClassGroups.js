define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsProductClassGroup'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsProductClassGroups',
		model: Model
	});

	return collection;
});
