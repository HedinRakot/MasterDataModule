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
		}
	});
	return model;
});
