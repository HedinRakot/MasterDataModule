define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsPfpPositions',
		fields: {
			id: { type: "number", editable: false }
			,text: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insPfpPosition', 'text'), 
				                    validation: { required: true, maxLength: 250 } }			
		}
	});
	return model;
});