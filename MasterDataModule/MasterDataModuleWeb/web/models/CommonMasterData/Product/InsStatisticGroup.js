define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsStatisticGroups',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insStatisticGroup', 'description'), 
				                    validation: { required: true, maxLength: 50 } }			
		}
	});
	return model;
});
