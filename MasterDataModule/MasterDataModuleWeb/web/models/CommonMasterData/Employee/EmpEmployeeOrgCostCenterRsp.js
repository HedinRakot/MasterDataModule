define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpEmployeeOrgCostCenterRsps',
		fields: {
			id: { type: "number", editable: false }
			,empEmployeeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('EmpEmployeeOrgCostCenterRsp', 'empEmployeeId'), 
				                    validation: { required: true } }			
			,orgCostCenterId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('EmpEmployeeOrgCostCenterRsp', 'orgCostCenterId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('EmpEmployeeOrgCostCenterRsp', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('EmpEmployeeOrgCostCenterRsp', 'toDate'), 
				                    validation: { required: true, date: true } }			
		},
		defaults: function () {
			var dnf = new Date();
			var dnt = new Date(2070,11,31);
			return {
				fromDate: dnf, 
				toDate: dnt
			};
		}
	});
	return model;
});
