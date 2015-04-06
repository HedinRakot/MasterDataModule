define([
	'base/base-collection',
	'models/Settings/MasterDataSubscribers'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataSubscribers',
		model: Model
	});

	return collection;
});
