define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/LegalBases',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('legalBasis', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('legalBasis', 'description'), 
				                    validation: { required: true, maxLength: 250 } }			
			,educationCertificateRequired: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('legalBasis', 'educationCertificateRequired'), 
				                    validation: { required: false } }			
			,firstAssignation: { type: "number", 
			                        editable: Application.canTableItemBeEdit('legalBasis', 'firstAssignation'), 
				                    validation: { required: true } }			
			,messageReason: { type: "string", 
			                        editable: Application.canTableItemBeEdit('legalBasis', 'messageReason'), 
				                    validation: { required: true, maxLength: 50 } }			
			,messageReasonStyle: { type: "string", 
			                        editable: Application.canTableItemBeEdit('legalBasis', 'messageReasonStyle'), 
				                    validation: { required: true, maxLength: 50 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('legalBasis', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('legalBasis', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,replacementId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('legalBasis', 'replacementId'), 
				                    validation: { required: false } }			
			,printName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('legalBasis', 'printName'), 
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
