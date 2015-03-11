define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsTaxClasses',
		fields: {
			id: { type: "number", editable: false }
			,taxClass: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insTaxClass', 'taxClass'), 
				                    validation: { required: true, maxLength: 10 } }			
		}
	});
	return model;
});
