define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgCostCenters',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgCostCenter', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgCostCenter', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgCostCenter', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgCostCenter', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
