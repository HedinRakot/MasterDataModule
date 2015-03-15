define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdBillingParameters',
		fields: {
			id: { type: "number", editable: false }
			,sapId: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordBillingParameter', 'sapId'), 
				                    validation: { required: true, maxLength: 10 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordBillingParameter', 'description'), 
				                    validation: { required: false, maxLength: 100 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordBillingParameter', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordBillingParameter', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
