define([
	'base/base-collection',
	'models/CommonMasterData/Customer/InsTaxClass'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsTaxClasses',
		model: Model
	});

	return collection;
});
