define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamClassArgeMaps',
		fields: {
			id: { type: "number", editable: false }
			,examNameArge: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examClassArgeMap', 'examNameArge'), 
				                    validation: { required: true, maxLength: 10 } }			
			,examClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examClassArgeMap', 'examClassId'), 
				                    validation: { required: true } }			
		}
	});
	return model;
});
