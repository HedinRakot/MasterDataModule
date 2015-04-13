define([
	'base/base-collection',
	'models/AdminService/WebSiteStatus'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/WebSiteMonitor',
        model: Model
    });

    return collection;
});
