define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/GetSitesStatuses',
		fields: {
			id: { type: "number", editable: false }
			,checkStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetSitesStatus', 'checkStatus'), 
				                    validation: { required: false } }			
			,checkDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('GetSitesStatus', 'checkDate'), 
				                    validation: { required: false, date: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetSitesStatus', 'message'), 
				                    validation: { required: false } }			
			,attempt: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetSitesStatus', 'attempt'), 
				                    validation: { required: false } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetSitesStatus', 'name'), 
				                    validation: { required: true } }			
			,sitePath: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetSitesStatus', 'sitePath'), 
				                    validation: { required: true } }			
			,logTypeInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetSitesStatus', 'logTypeInfoId'), 
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
