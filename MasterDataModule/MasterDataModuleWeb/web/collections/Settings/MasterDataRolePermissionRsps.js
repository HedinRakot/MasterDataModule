define([
	'base/base-collection',
	'models/Settings/MasterDataRolePermissionRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataRolePermissionRsps',
		model: Model
	});

	return collection;
});
