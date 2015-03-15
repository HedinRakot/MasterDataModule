define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdFederalStates',
		fields: {
			id: { type: "number", editable: false }
			,federalStateName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordFederalState', 'federalStateName'), 
				                    validation: { required: true, maxLength: 10 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordFederalState', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,sysCountryId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ordFederalState', 'sysCountryId'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordFederalState', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordFederalState', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
