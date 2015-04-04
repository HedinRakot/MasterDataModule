define([
	'base/base-collection',
	'models/Settings/ApplicationLogs'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ApplicationLogs',
		model: Model
	});

	return collection;
});
