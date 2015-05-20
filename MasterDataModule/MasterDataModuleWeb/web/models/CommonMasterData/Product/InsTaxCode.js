define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsTaxCodes',
		fields: {
			id: { type: "number", editable: false }
			,taxCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsTaxCode', 'taxCode'), 
				                    validation: { required: true, maxLength: 10 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsTaxCode', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsTaxCode', 'toDate'), 
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
