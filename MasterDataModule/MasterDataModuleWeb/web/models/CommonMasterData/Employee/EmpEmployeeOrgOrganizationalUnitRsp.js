define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpEmployeeOrgOrganizationalUnitRsps',
		fields: {
			id: { type: "number", editable: false }
			,empEmployeeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('empEmployeeOrgOrganizationalUnitRsp', 'empEmployeeId'), 
				                    validation: { required: true } }			
			,orgOrganizationalUnitId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('empEmployeeOrgOrganizationalUnitRsp', 'orgOrganizationalUnitId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('empEmployeeOrgOrganizationalUnitRsp', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('empEmployeeOrgOrganizationalUnitRsp', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
