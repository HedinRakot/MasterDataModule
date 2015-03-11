define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsSeverityTypes',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insSeverityType', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insSeverityType', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
		}
	});
	return model;
});
