define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsVatTypes',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsVatType', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,taxCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsVatType', 'taxCode'), 
				                    validation: { required: true, maxLength: 10 } }			
			,percent: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsVatType', 'percent'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsVatType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsVatType', 'toDate'), 
				                    validation: { required: true, date: true } }			
		},
		defaults: function () {
			var dnf = new Date();
			var dnt = new Date(2070,11,31);
			return {
				fromDate: dnf, 
				toDate: dnt
			};
		}
	});
	return model;
});
