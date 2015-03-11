define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsTaxCodes',
		fields: {
			id: { type: "number", editable: false }
			,taxCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insTaxCode', 'taxCode'), 
				                    validation: { required: true, maxLength: 10 } }			
		}
	});
	return model;
});
