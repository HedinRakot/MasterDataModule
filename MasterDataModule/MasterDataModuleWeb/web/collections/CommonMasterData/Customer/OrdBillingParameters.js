define([
	'base/base-collection',
	'models/CommonMasterData/Customer/OrdBillingParameter'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrdBillingParameters',
		model: Model
	});

	return collection;
});
