define([
	'base/base-collection',
	'models/settings/role'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
		url: 'api/roles',
		model: Model
	});

	return collection;
});