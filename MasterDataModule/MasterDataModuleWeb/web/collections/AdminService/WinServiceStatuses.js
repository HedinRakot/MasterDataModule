define([
	'base/base-collection',
	'models/AdminService/WinServiceStatus'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/GetWinServicesStatuses',
        model: Model
    });

    return collection;
});
