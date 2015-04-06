define([
	'base/base-collection',
	'models/Settings/MasterDataNotificationsMasterDataSubscribersRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataNotificationsMasterDataSubscribersRsps',
		model: Model
	});

	return collection;
});
