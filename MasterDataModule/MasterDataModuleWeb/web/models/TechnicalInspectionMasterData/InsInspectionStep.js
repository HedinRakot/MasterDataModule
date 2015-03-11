define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsInspectionSteps',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insInspectionStep', 'description'), 
				                    validation: { required: true, maxLength: 150 } }			
		}
	});
	return model;
});
