define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamRecognitionTypeExamClasses',
		fields: {
			id: { type: "number", editable: false }
			,examRecognitionTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examRecognitionTypeExamClass', 'examRecognitionTypeId'), 
				                    validation: { required: true } }			
			,examClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examRecognitionTypeExamClass', 'examClassId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examRecognitionTypeExamClass', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examRecognitionTypeExamClass', 'toDate'), 
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
