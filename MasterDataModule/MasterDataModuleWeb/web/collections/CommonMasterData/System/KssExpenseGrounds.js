define([
	'base/base-collection',
	'models/CommonMasterData/System/KssExpenseGround'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/KssExpenseGrounds',
		model: Model
	});

	return collection;
});
