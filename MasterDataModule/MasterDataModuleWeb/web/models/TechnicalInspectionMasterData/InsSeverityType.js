define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsSeverityTypes',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insSeverityType', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insSeverityType', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insSeverityType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insSeverityType', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
