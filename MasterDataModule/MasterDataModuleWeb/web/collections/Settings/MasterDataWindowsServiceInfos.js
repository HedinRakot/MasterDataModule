define([
	'base/base-collection',
	'models/Settings/MasterDataWindowsServiceInfo'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataWindowsServiceInfos',
		model: Model
	});

	return collection;
});
