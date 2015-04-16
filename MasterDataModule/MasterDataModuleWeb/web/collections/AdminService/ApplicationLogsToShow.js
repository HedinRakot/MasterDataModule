define([
	'base/base-collection',
	'models/AdminService/ApplicationLogToShow'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/ApplicationLogToShow',
        model: Model
    });

    return collection;
});
