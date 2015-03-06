define([
	'base/base-collection',
	'models/settings/sysTable'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/sysTables',
		model: Model
	});

	return collection;
});