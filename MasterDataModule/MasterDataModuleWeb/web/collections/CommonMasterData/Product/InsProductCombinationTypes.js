define([
	'base/base-collection',
	'models/CommonMasterData/Product/InsProductCombinationType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsProductCombinationTypes',
		model: Model
	});

	return collection;
});
