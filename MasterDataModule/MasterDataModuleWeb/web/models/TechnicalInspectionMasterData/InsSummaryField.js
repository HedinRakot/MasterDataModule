define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsSummaryFields',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insSummaryField', 'description'), 
				                    validation: { required: true, maxLength: 250 } }			
		}
	});
	return model;
});
