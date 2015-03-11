define([
	'base/base-collection',
	'models/CommonMasterData/System/SysRoleSysPermissionRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/SysRoleSysPermissionRsps',
		model: Model
	});

	return collection;
});
