define([
	'base/base-collection',
	'models/CommonMasterData/Employee/EmpCashPermissionType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/EmpCashPermissionTypes',
		model: Model
	});

	return collection;
});
