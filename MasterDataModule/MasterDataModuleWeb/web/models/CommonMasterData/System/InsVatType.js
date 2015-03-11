define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsVatTypes',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insVatType', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,taxCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insVatType', 'taxCode'), 
				                    validation: { required: true, maxLength: 10 } }			
			,percent: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insVatType', 'percent'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
