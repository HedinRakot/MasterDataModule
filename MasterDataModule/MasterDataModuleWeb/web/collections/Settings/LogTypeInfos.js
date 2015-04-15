define([
	'base/base-collection',
	'models/Settings/LogTypeInfo'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/LogTypeInfos',
		model: Model
	});

	return collection;
});
