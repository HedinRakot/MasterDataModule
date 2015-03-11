define([
	'base/base-collection',
	'models/CommonMasterData/Customer/OrdContactPersonFunction'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrdContactPersonFunctions',
		model: Model
	});

	return collection;
});
