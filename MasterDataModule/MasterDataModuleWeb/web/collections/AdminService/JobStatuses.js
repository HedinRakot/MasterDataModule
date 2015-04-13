define([
	'base/base-collection',
	'models/AdminService/JobStatus'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/JobMonitor',
        model: Model
    });

    return collection;
});
