define([
	'base/base-collection',
	'models/Settings/MasterDataMonitorableInfoMasterDataNotificationsRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataMonitorableInfoMasterDataNotificationsRsps',
		model: Model
	});

	return collection;
});
