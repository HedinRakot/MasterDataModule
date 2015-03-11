define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdRecognitions',
		fields: {
			id: { type: "number", editable: false }
			,ordRecognitionTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ordRecognition', 'ordRecognitionTypeId'), 
				                    validation: { required: true } }			
			,orgAccountingAreaId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ordRecognition', 'orgAccountingAreaId'), 
				                    validation: { required: true } }			
		}
	});
	return model;
});
