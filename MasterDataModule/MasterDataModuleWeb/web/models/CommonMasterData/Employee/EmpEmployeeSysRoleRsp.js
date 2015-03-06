define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpEmployeeSysRoleRsps',
		fields: {
			id: { type: "number", editable: false },
			empEmployeeId: { type: "number", editable: Application.canTableItemBeEdit('empEmployeeSysRoleRsp', 'empEmployeeId'), validation: { required: true/*, maxLength: 250*/ } },
			sysRoleId: { type: "number", editable: Application.canTableItemBeEdit('empEmployeeSysRoleRsp', 'sysRoleId'), validation: { required: true } },
			fromDate: { type: "date", editable: Application.canTableItemBeEdit('empEmployeeSysRoleRsp', 'fromDate'), validation: { required: true, date: true } },
			toDate: { type: "date", editable: Application.canTableItemBeEdit('empEmployeeSysRoleRsp', 'toDate'), validation: { required: true, date: true } },
		}
	});

	return model;
});