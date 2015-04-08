define([
	'base/base-collection',
	'models/AdminService/JobMonitor/JobStatus'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/JobMonitor',
        model: Model
    });

    return collection;
});
