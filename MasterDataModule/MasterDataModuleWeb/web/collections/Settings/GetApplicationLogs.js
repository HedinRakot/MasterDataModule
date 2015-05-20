define([
	'base/base-collection',
	'models/Settings/GetApplicationLogs'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/GetApplicationLogs',
		model: Model
	});

	return collection;
});
