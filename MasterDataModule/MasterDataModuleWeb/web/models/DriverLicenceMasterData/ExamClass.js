define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamClasses',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examClass', 'name'), 
				                    validation: { required: true, maxLength: 10 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examClass', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,isMofa: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('examClass', 'isMofa'), 
				                    validation: { required: false } }			
			,isFsClass: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('examClass', 'isFsClass'), 
				                    validation: { required: false } }			
			,sortOrder: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examClass', 'sortOrder'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
