define([
	'base/base-collection',
	'models/Settings/SysTable'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/SysTables',
		model: Model
	});

	return collection;
});
