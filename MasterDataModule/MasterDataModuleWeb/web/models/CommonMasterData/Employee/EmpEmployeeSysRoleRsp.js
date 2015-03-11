define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpEmployeeSysRoleRsps',
		fields: {
			id: { type: "number", editable: false }
			,empEmployeeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('empEmployeeSysRoleRsp', 'empEmployeeId'), 
				                    validation: { required: true } }			
			,sysRoleId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('empEmployeeSysRoleRsp', 'sysRoleId'), 
				                    validation: { required: true } }			
		}
	});
	return model;
});
