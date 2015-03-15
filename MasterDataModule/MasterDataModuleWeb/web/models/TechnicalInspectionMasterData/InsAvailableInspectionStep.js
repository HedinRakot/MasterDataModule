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
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insAvailableInspectionStep', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insAvailableInspectionStep', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
