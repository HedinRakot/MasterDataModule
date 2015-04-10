define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamClassInclusiveClasses',
		fields: {
			id: { type: "number", editable: false }
			,examClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ExamClassInclusiveClass', 'examClassId'), 
				                    validation: { required: true } }			
			,examClassIdInclusive: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ExamClassInclusiveClass', 'examClassIdInclusive'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ExamClassInclusiveClass', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ExamClassInclusiveClass', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,isConditional: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('ExamClassInclusiveClass', 'isConditional'), 
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
