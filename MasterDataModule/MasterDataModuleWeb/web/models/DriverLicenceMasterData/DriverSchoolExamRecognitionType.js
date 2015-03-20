define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/DriverSchoolExamRecognitionTypes',
		fields: {
			id: { type: "number", editable: false }
			,driverSchoolId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('driverSchoolExamRecognitionType', 'driverSchoolId'), 
				                    validation: { required: true } }			
			,examRecognitionTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('driverSchoolExamRecognitionType', 'examRecognitionTypeId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('driverSchoolExamRecognitionType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('driverSchoolExamRecognitionType', 'toDate'), 
				                    validation: { required: true, date: true } }			
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
