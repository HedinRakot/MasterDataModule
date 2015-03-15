define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsStatisticGroups',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insStatisticGroup', 'description'), 
				                    validation: { required: true, maxLength: 50 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insStatisticGroup', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insStatisticGroup', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
