define([
	'base/base-collection',
	'models/CommonMasterData/Employee/EmpEmployeeTopEmployeeRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/EmpEmployeeTopEmployeeRsps',
		model: Model
	});

	return collection;
});
