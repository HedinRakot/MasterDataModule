define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsTaxCodes',
		fields: {
			id: { type: "number", editable: false }
			,taxCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insTaxCode', 'taxCode'), 
				                    validation: { required: true, maxLength: 10 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insTaxCode', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insTaxCode', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
