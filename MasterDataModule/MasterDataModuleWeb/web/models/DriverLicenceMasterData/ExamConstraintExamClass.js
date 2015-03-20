define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamConstraintExamClasses',
		fields: {
			id: { type: "number", editable: false }
			,examConstraintId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examConstraintExamClass', 'examConstraintId'), 
				                    validation: { required: true } }			
			,examClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examConstraintExamClass', 'examClassId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examConstraintExamClass', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examConstraintExamClass', 'toDate'), 
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
