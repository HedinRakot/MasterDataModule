define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsVatTypes',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insVatType', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,taxCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insVatType', 'taxCode'), 
				                    validation: { required: true, maxLength: 10 } }			
			,percent: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insVatType', 'percent'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insVatType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insVatType', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
