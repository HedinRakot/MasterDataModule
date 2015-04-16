define([
	'base/base-collection',
	'models/Settings/SiteInfosWithLastResult'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/SiteInfosWithLastResults',
		model: Model
	});

	return collection;
});
