define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdFederalStates',
		fields: {
			id: { type: "number", editable: false }
			,federalStateName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('OrdFederalState', 'federalStateName'), 
				                    validation: { required: true, maxLength: 10 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('OrdFederalState', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,sysCountryId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrdFederalState', 'sysCountryId'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrdFederalState', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrdFederalState', 'toDate'), 
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
