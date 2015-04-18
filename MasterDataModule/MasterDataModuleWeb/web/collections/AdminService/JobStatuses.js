define([
	'base/base-collection',
	'models/AdminService/JobStatus'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/GetJobsStatuses',
        model: Model
    });

    return collection;
});
