define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamClassInclusiveClasses',
		fields: {
			id: { type: "number", editable: false }
			,examClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examClassInclusiveClass', 'examClassId'), 
				                    validation: { required: true } }			
			,examClassIdInclusive: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examClassInclusiveClass', 'examClassIdInclusive'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examClassInclusiveClass', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examClassInclusiveClass', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,isConditional: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('examClassInclusiveClass', 'isConditional'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
