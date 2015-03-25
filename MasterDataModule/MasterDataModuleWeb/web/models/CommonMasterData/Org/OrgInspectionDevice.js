define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgInspectionDevices',
		fields: {
			id: { type: "number", editable: false }
			,debitorCustomerNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'debitorCustomerNumber'), 
				                    validation: { required: false, maxLength: 10 } }			
			,identification: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'identification'), 
				                    validation: { required: true, maxLength: 15 } }			
			,newIdentification: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'newIdentification'), 
				                    validation: { required: false, maxLength: 15 } }			
			,oldIdentification: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'oldIdentification'), 
				                    validation: { required: false, maxLength: 15 } }			
			,type: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'type'), 
				                    validation: { required: false, maxLength: 1 } }			
			,serialNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'serialNumber'), 
				                    validation: { required: false, maxLength: 50 } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'name'), 
				                    validation: { required: false, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,lastInspectionDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'lastInspectionDate'), 
				                    validation: { required: false, date: true } }			
			,lastInspectionResult: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'lastInspectionResult'), 
				                    validation: { required: false, maxLength: 20 } }			
			,inspectionDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'inspectionDate'), 
				                    validation: { required: false, date: true } }			
			,inspectionInterval: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'inspectionInterval'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgInspectionDevice', 'toDate'), 
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
