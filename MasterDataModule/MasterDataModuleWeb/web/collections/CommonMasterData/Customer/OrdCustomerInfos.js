define([
	'base/base-collection',
	'models/CommonMasterData/Customer/OrdCustomerInfo'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrdCustomerInfos',
		model: Model
	});

	return collection;
});
