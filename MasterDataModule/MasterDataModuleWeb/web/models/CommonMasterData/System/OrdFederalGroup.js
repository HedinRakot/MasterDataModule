define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdFederalGroups',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordFederalGroup', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordFederalGroup', 'description'), 
				                    validation: { required: false, maxLength: 200 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordFederalGroup', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordFederalGroup', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
