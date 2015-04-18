define([
	'base/base-collection',
	'models/AdminService/ApplicationLogToShow'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/GetApplicationLogs',
        model: Model
    });

    return collection;
});
