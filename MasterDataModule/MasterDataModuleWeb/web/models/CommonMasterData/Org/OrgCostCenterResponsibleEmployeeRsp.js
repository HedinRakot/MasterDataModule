define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgCostCenterResponsibleEmployeeRsps',
		fields: {
			id: { type: "number", editable: false }
			,orgCostCenterId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterResponsibleEmployeeRsp', 'orgCostCenterId'), 
				                    validation: { required: true } }			
			,empEmployeeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterResponsibleEmployeeRsp', 'empEmployeeId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterResponsibleEmployeeRsp', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterResponsibleEmployeeRsp', 'toDate'), 
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
