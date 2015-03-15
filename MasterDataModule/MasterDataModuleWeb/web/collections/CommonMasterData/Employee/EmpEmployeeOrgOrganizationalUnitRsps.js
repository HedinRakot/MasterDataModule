define([
	'base/base-collection',
	'models/CommonMasterData/Employee/EmpEmployeeOrgOrganizationalUnitRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/EmpEmployeeOrgOrganizationalUnitRsps',
		model: Model
	});

	return collection;
});
