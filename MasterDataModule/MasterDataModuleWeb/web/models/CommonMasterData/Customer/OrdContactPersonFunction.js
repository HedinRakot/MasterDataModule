define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdContactPersonFunctions',
		fields: {
			id: { type: "number", editable: false }
			,sapId: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordContactPersonFunction', 'sapId'), 
				                    validation: { required: true, maxLength: 10 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordContactPersonFunction', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
		}
	});
	return model;
});
