define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsProductTypes',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insProductType', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insProductType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insProductType', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
