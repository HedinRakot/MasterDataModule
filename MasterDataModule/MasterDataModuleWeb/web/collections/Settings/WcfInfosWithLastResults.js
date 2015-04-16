define([
	'base/base-collection',
	'models/Settings/WcfInfosWithLastResult'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/WcfInfosWithLastResults',
		model: Model
	});

	return collection;
});
