define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsTaxClasses',
		fields: {
			id: { type: "number", editable: false }
			,taxClass: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsTaxClass', 'taxClass'), 
				                    validation: { required: true, maxLength: 10 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsTaxClass', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsTaxClass', 'toDate'), 
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
