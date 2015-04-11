define([
	'base/base-collection',
	'models/Settings/MasterDataWindowsServiceCheckResults'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataWindowsServiceCheckResults',
		model: Model
	});

	return collection;
});
