define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsProductObjectClasses',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductObjectClass', 'description'), 
				                    validation: { required: true, maxLength: 50 } }			
			,weightFrom: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insProductObjectClass', 'weightFrom'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
