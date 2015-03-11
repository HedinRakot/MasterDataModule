define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamConstraints',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examConstraint', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examConstraint', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,constraintType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examConstraint', 'constraintType'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
