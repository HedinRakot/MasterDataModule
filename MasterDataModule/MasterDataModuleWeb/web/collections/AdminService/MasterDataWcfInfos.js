define([
	'base/base-collection',
	'models/AdminService/WebServiceMonitor/MasterDataWcfInfo'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/MasterDataWcfInfo',
        model: Model
    });

    return collection;
});
