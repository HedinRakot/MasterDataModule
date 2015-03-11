define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsAvailableInspectionSteps',
		fields: {
			id: { type: "number", editable: false }
			,insInspectionStepId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insAvailableInspectionStep', 'insInspectionStepId'), 
				                    validation: { required: true } }			
			,isMandatory: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insAvailableInspectionStep', 'isMandatory'), 
				                    validation: { required: true } }			
		}
	});
	return model;
});
