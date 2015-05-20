define([
	'base/base-collection',
	'models/Settings/GetWinServicesStatus'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/GetWinServicesStatuses',
		model: Model
	});

	return collection;
});
