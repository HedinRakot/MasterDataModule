define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamClassRestrictedClasses',
		fields: {
			id: { type: "number", editable: false }
			,examClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examClassRestrictedClass', 'examClassId'), 
				                    validation: { required: true } }			
			,examClassIdRestricted: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examClassRestrictedClass', 'examClassIdRestricted'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examClassRestrictedClass', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examClassRestrictedClass', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
