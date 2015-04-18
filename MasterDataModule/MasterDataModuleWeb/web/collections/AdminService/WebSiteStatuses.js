define([
	'base/base-collection',
	'models/AdminService/WebSiteStatus'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/GetSitesStatuses',
        model: Model
    });

    return collection;
});
