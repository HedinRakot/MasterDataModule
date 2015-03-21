define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/Authorities',
		fields: {
			id: { type: "number", editable: false }
			,authorityNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('authority', 'authorityNumber'), 
				                    validation: { required: true, maxLength: 13 } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('authority', 'name'), 
				                    validation: { required: true, maxLength: 100 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('authority', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,isCertificateRequired: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('authority', 'isCertificateRequired'), 
				                    validation: { required: false } }			
			,returnType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('authority', 'returnType'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('authority', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('authority', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,name2: { type: "string", 
			                        editable: Application.canTableItemBeEdit('authority', 'name2'), 
				                    validation: { required: false, maxLength: 100 } }			
			,streetHouseNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('authority', 'streetHouseNumber'), 
				                    validation: { required: false, maxLength: 220 } }			
			,zipCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('authority', 'zipCode'), 
				                    validation: { required: false, maxLength: 90 } }			
			,city: { type: "string", 
			                        editable: Application.canTableItemBeEdit('authority', 'city'), 
				                    validation: { required: false, maxLength: 160 } }			
			,sysCountryId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('authority', 'sysCountryId'), 
				                    validation: { required: false } }			
			,phone1: { type: "string", 
			                        editable: Application.canTableItemBeEdit('authority', 'phone1'), 
				                    validation: { required: false, maxLength: 90 } }			
			,phone2: { type: "string", 
			                        editable: Application.canTableItemBeEdit('authority', 'phone2'), 
				                    validation: { required: false, maxLength: 90 } }			
			,fax: { type: "string", 
			                        editable: Application.canTableItemBeEdit('authority', 'fax'), 
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
