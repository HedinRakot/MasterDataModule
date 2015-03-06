define([
	'base/base-collection',
	'models/settings/permission'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
		url: 'api/permissions',
		model: Model
	});

	return collection;
});