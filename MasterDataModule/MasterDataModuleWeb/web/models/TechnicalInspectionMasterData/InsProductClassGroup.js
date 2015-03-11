define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsProductClassGroups',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductClassGroup', 'description'), 
				                    validation: { required: false, maxLength: 500 } }			
			,sapId: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductClassGroup', 'sapId'), 
				                    validation: { required: true, maxLength: 10 } }			
		}
	});
	return model;
});
