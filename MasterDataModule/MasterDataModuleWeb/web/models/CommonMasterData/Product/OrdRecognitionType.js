define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdRecognitionTypes',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordRecognitionType', 'name'), 
				                    validation: { required: false, maxLength: 50 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordRecognitionType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordRecognitionType', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
