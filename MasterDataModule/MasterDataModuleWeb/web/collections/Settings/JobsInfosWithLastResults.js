define([
	'base/base-collection',
	'models/Settings/JobsInfosWithLastResult'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/JobsInfosWithLastResults',
		model: Model
	});

	return collection;
});
