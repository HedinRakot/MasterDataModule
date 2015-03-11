define([
	'base/base-collection',
	'models/CommonMasterData/Product/InsProductType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsProductTypes',
		model: Model
	});

	return collection;
});
