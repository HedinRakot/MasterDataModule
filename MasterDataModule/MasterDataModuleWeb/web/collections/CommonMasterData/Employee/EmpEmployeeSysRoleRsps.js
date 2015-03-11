define([
	'base/base-collection',
	'models/CommonMasterData/Employee/EmpEmployeeSysRoleRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/EmpEmployeeSysRoleRsps',
		model: Model
	});

	return collection;
});
