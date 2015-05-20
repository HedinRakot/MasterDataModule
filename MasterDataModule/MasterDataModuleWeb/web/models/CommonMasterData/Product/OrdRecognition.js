define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdRecognitions',
		fields: {
			id: { type: "number", editable: false }
			,ordRecognitionTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrdRecognition', 'ordRecognitionTypeId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrdRecognition', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrdRecognition', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,orgAccountingAreaId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrdRecognition', 'orgAccountingAreaId'), 
				                    validation: { required: true } }			
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
