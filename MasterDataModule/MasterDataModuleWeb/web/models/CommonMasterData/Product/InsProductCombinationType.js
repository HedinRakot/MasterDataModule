define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsProductCombinationTypes',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductCombinationType', 'description'), 
				                    validation: { required: true, maxLength: 50 } }			
		}
	});
	return model;
});
