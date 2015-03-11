define([
	'base/base-collection',
	'models/CommonMasterData/Product/InsTaxCode'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsTaxCodes',
		model: Model
	});

	return collection;
});
