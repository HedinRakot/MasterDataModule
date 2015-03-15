define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsSummaryFields',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insSummaryField', 'description'), 
				                    validation: { required: true, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insSummaryField', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insSummaryField', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
