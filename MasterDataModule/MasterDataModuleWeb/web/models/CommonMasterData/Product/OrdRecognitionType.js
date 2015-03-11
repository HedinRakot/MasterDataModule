define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdRecognitionTypes',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordRecognitionType', 'name'), 
				                    validation: { required: false, maxLength: 50 } }			
		}
	});
	return model;
});
