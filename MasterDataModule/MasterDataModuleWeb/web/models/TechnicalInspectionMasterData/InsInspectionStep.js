define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsInspectionSteps',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insInspectionStep', 'description'), 
				                    validation: { required: true, maxLength: 150 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insInspectionStep', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insInspectionStep', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
