define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamStationExamRecognitionTypes',
		fields: {
			id: { type: "number", editable: false }
			,examStationId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examStationExamRecognitionType', 'examStationId'), 
				                    validation: { required: true } }			
			,examRecognitionTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examStationExamRecognitionType', 'examRecognitionTypeId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examStationExamRecognitionType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examStationExamRecognitionType', 'toDate'), 
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
