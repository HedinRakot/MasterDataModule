define([
	'base/base-collection',
	'models/settings/user'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
		url: 'api/users',
		model: Model
	});

	return collection;
});