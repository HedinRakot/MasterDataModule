define([
	'base/base-collection',
	'models/Settings/GetJobsStatus'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/GetJobsStatuses',
		model: Model
	});

	return collection;
});
