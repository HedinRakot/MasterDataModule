define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/GetWcfServicesStatuses',
		fields: {
			id: { type: "number", editable: false }
			,checkStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetWcfServicesStatus', 'checkStatus'), 
				                    validation: { required: false } }			
			,checkDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('GetWcfServicesStatus', 'checkDate'), 
				                    validation: { required: false, date: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetWcfServicesStatus', 'message'), 
				                    validation: { required: false } }			
			,attempt: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetWcfServicesStatus', 'attempt'), 
				                    validation: { required: false } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetWcfServicesStatus', 'name'), 
				                    validation: { required: false } }			
			,wsdlPath: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetWcfServicesStatus', 'wsdlPath'), 
				                    validation: { required: false } }			
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
