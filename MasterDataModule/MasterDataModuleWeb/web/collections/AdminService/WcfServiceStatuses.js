﻿define([
	'base/base-collection',
	'models/AdminService/WcfServiceStatus'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/WebServiceMonitor',
        model: Model
    });

    return collection;
});
