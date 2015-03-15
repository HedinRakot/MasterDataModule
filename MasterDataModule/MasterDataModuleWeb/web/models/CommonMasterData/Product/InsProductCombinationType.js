define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsProductCombinationTypes',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductCombinationType', 'description'), 
				                    validation: { required: true, maxLength: 50 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insProductCombinationType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insProductCombinationType', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
