define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsProductMaterialGroups',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductMaterialGroup', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,sapId: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductMaterialGroup', 'sapId'), 
				                    validation: { required: true, maxLength: 10 } }			
		}
	});
	return model;
});
