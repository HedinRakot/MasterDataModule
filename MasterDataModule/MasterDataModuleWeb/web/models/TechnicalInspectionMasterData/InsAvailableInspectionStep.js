define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsAvailableInspectionSteps',
		fields: {
			id: { type: "number", editable: false }
			,insInspectionStepId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsAvailableInspectionStep', 'insInspectionStepId'), 
				                    validation: { required: true } }			
			,isMandatory: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsAvailableInspectionStep', 'isMandatory'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsAvailableInspectionStep', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsAvailableInspectionStep', 'toDate'), 
				                    validation: { required: true, date: true } }			
		},
		defaults: function () {
			var dnf = new Date();
			var dnt = new Date(2070,11,31);
			return {
				fromDate: dnf, 
				toDate: dnt
			};
		}
	});
	return model;
});
