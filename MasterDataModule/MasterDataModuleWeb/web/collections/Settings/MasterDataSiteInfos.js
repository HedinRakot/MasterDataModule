define([
	'base/base-collection',
	'models/Settings/MasterDataSiteInfo'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataSiteInfos',
		model: Model
	});

	return collection;
});
