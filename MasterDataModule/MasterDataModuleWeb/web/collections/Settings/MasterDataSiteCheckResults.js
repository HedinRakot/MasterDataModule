define([
	'base/base-collection',
	'models/Settings/MasterDataSiteCheckResults'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataSiteCheckResults',
		model: Model
	});

	return collection;
});
