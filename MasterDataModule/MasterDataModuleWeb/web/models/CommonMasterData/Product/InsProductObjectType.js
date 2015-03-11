define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsProductObjectTypes',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductObjectType', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,sapId: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductObjectType', 'sapId'), 
				                    validation: { required: true, maxLength: 10 } }			
			,isAuNecessary: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insProductObjectType', 'isAuNecessary'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
