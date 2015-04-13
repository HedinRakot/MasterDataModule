define([
	'base/base-collection',
	'models/AdminService/WinServiceStatus'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/WinServiceMonitor',
        model: Model
    });

    return collection;
});
