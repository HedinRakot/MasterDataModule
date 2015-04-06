define([
	'base/base-collection',
	'models/Settings/MasterDataNotifications'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataNotifications',
		model: Model
	});

	return collection;
});
