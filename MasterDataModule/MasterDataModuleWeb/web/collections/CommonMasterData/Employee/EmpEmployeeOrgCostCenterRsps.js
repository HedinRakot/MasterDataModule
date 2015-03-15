define([
	'base/base-collection',
	'models/CommonMasterData/Employee/EmpEmployeeOrgCostCenterRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/EmpEmployeeOrgCostCenterRsps',
		model: Model
	});

	return collection;
});
