define([
	'base/base-collection',
	'models/settings/systemLogRecord'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
		url: 'api/systemlog',
		model: Model
	});

	return collection;
});