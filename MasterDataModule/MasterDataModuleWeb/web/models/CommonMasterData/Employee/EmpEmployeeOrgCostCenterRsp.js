define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpEmployeeOrgCostCenterRsps',
		fields: {
			id: { type: "number", editable: false }
			,empEmployeeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('empEmployeeOrgCostCenterRsp', 'empEmployeeId'), 
				                    validation: { required: true } }			
			,orgCostCenterId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('empEmployeeOrgCostCenterRsp', 'orgCostCenterId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('empEmployeeOrgCostCenterRsp', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('empEmployeeOrgCostCenterRsp', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
