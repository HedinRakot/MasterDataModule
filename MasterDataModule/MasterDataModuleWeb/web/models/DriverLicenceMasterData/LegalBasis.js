define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/LegalBases',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('LegalBasis', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('LegalBasis', 'description'), 
				                    validation: { required: true, maxLength: 250 } }			
			,educationCertificateRequired: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('LegalBasis', 'educationCertificateRequired'), 
				                    validation: { required: false } }			
			,firstAssignation: { type: "number", 
			                        editable: Application.canTableItemBeEdit('LegalBasis', 'firstAssignation'), 
				                    validation: { required: true } }			
			,messageReason: { type: "string", 
			                        editable: Application.canTableItemBeEdit('LegalBasis', 'messageReason'), 
				                    validation: { required: true, maxLength: 50 } }			
			,messageReasonStyle: { type: "string", 
			                        editable: Application.canTableItemBeEdit('LegalBasis', 'messageReasonStyle'), 
				                    validation: { required: true, maxLength: 50 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('LegalBasis', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('LegalBasis', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,replacementId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('LegalBasis', 'replacementId'), 
				                    validation: { required: false } }			
			,printName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('LegalBasis', 'printName'), 
				                    validation: { required: true, maxLength: 50 } }			
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
