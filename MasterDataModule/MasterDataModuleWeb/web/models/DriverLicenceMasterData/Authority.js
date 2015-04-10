define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/Authorities',
		fields: {
			id: { type: "number", editable: false }
			,authorityNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('Authority', 'authorityNumber'), 
				                    validation: { required: true, maxLength: 13 } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('Authority', 'name'), 
				                    validation: { required: true, maxLength: 100 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('Authority', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,isCertificateRequired: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('Authority', 'isCertificateRequired'), 
				                    validation: { required: false } }			
			,returnType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('Authority', 'returnType'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('Authority', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('Authority', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,name2: { type: "string", 
			                        editable: Application.canTableItemBeEdit('Authority', 'name2'), 
				                    validation: { required: false, maxLength: 100 } }			
			,streetHouseNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('Authority', 'streetHouseNumber'), 
				                    validation: { required: false, maxLength: 220 } }			
			,zipCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('Authority', 'zipCode'), 
				                    validation: { required: false, maxLength: 90 } }			
			,city: { type: "string", 
			                        editable: Application.canTableItemBeEdit('Authority', 'city'), 
				                    validation: { required: false, maxLength: 160 } }			
			,sysCountryId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('Authority', 'sysCountryId'), 
				                    validation: { required: false } }			
			,phone1: { type: "string", 
			                        editable: Application.canTableItemBeEdit('Authority', 'phone1'), 
				                    validation: { required: false, maxLength: 90 } }			
			,phone2: { type: "string", 
			                        editable: Application.canTableItemBeEdit('Authority', 'phone2'), 
				                    validation: { required: false, maxLength: 90 } }			
			,fax: { type: "string", 
			                        editable: Application.canTableItemBeEdit('Authority', 'fax'), 
				                    validation: { required: false, maxLength: 90 } }			
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
