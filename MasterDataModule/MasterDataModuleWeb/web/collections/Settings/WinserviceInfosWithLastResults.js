define([
	'base/base-collection',
	'models/Settings/WinserviceInfosWithLastResult'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/WinserviceInfosWithLastResults',
		model: Model
	});

	return collection;
});
