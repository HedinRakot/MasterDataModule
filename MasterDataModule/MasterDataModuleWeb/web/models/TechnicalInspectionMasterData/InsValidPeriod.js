define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsValidPeriods',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insValidPeriod', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,validityPeriod: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insValidPeriod', 'validityPeriod'), 
				                    validation: { required: true } }			
			,isNextTerminPossible: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insValidPeriod', 'isNextTerminPossible'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insValidPeriod', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insValidPeriod', 'toDate'), 
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
