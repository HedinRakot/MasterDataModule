define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsProductTypes',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductType', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
		}
	});
	return model;
});
