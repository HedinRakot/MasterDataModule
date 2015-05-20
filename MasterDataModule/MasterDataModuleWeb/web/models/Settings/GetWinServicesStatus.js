define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/GetWinServicesStatuses',
		fields: {
			id: { type: "number", editable: false }
			,checkStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetWinServicesStatus', 'checkStatus'), 
				                    validation: { required: false } }			
			,checkDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('GetWinServicesStatus', 'checkDate'), 
				                    validation: { required: false, date: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetWinServicesStatus', 'message'), 
				                    validation: { required: false } }			
			,attempt: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetWinServicesStatus', 'attempt'), 
				                    validation: { required: false } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetWinServicesStatus', 'name'), 
				                    validation: { required: true } }			
			,machineName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetWinServicesStatus', 'machineName'), 
				                    validation: { required: true } }			
			,logTypeInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetWinServicesStatus', 'logTypeInfoId'), 
				                    validation: { required: true } }			
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
