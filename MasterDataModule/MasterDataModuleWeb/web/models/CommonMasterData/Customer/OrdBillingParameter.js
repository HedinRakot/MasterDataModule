define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdBillingParameters',
		fields: {
			id: { type: "number", editable: false }
			,sapId: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordBillingParameter', 'sapId'), 
				                    validation: { required: true, maxLength: 10 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordBillingParameter', 'description'), 
				                    validation: { required: false, maxLength: 100 } }			
		}
	});
	return model;
});
