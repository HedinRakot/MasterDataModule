define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamPossibleResults',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examPossibleResult', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examPossibleResult', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,isFeePayable: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('examPossibleResult', 'isFeePayable'), 
				                    validation: { required: false } }			
			,examCounterFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('examPossibleResult', 'examCounterFlag'), 
				                    validation: { required: false } }			
			,nextExamProductFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('examPossibleResult', 'nextExamProductFlag'), 
				                    validation: { required: false } }			
			,driverLicenceFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('examPossibleResult', 'driverLicenceFlag'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examPossibleResult', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examPossibleResult', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,isMedicalAttestRequired: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('examPossibleResult', 'isMedicalAttestRequired'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
