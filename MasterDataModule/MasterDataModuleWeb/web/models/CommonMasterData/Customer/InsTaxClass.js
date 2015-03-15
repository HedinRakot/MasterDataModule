define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsTaxClasses',
		fields: {
			id: { type: "number", editable: false }
			,taxClass: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insTaxClass', 'taxClass'), 
				                    validation: { required: true, maxLength: 10 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insTaxClass', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insTaxClass', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
