define([
	'base/base-collection',
	'models/Settings/MasterDataWcfCheckResults'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataWcfCheckResults',
		model: Model
	});

	return collection;
});
