define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExpPassengersTypes',
		fields: {
			id: { type: "number", editable: false }
			,text: { type: "string", 
			                        editable: Application.canTableItemBeEdit('expPassengersType', 'text'), 
				                    validation: { required: true, maxLength: 100 } }			
			,code: { type: "string", 
			                        editable: Application.canTableItemBeEdit('expPassengersType', 'code'), 
				                    validation: { required: true, maxLength: 2 } }			
		}
	});
	return model;
});
