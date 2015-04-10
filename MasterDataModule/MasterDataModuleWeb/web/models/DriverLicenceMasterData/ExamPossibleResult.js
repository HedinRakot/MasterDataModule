define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamPossibleResults',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamPossibleResult', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamPossibleResult', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,isFeePayable: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('ExamPossibleResult', 'isFeePayable'), 
				                    validation: { required: false } }			
			,examCounterFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('ExamPossibleResult', 'examCounterFlag'), 
				                    validation: { required: false } }			
			,nextExamProductFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('ExamPossibleResult', 'nextExamProductFlag'), 
				                    validation: { required: false } }			
			,driverLicenceFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('ExamPossibleResult', 'driverLicenceFlag'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ExamPossibleResult', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ExamPossibleResult', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,isMedicalAttestRequired: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('ExamPossibleResult', 'isMedicalAttestRequired'), 
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
