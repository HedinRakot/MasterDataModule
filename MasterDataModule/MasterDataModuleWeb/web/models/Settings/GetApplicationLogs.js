define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/GetApplicationLogs',
		fields: {
			id: { type: "number", editable: false }
			,logLevel: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetApplicationLogs', 'logLevel'), 
				                    validation: { required: true } }			
			,messageDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('GetApplicationLogs', 'messageDate'), 
				                    validation: { required: true, date: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetApplicationLogs', 'message'), 
				                    validation: { required: true } }			
			,fileName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetApplicationLogs', 'fileName'), 
				                    validation: { required: true, maxLength: 250 } }			
			,logTypeInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetApplicationLogs', 'logTypeInfoId'), 
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
