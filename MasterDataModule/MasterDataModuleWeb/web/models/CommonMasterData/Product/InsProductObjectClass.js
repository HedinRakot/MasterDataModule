define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsProductObjectClasses',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductObjectClass', 'description'), 
				                    validation: { required: true, maxLength: 50 } }			
			,weightFrom: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insProductObjectClass', 'weightFrom'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insProductObjectClass', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insProductObjectClass', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
