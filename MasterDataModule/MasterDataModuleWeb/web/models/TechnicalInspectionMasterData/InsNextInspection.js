define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsNextInspections',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insNextInspection', 'description'), 
				                    validation: { required: true, maxLength: 50 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insNextInspection', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insNextInspection', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
