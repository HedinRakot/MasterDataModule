define([
	'base/base-collection',
	'models/CommonMasterData/System/SysRole'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/SysRoles',
		model: Model
	});

	return collection;
});
