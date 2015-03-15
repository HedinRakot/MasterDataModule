define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdRecognitionAreaOfWorkRsps',
		fields: {
			id: { type: "number", editable: false }
			,ordRecognitionId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ordRecognitionAreaOfWorkRsp', 'ordRecognitionId'), 
				                    validation: { required: true } }			
			,ordAreaOfWorkId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ordRecognitionAreaOfWorkRsp', 'ordAreaOfWorkId'), 
				                    validation: { required: true } }			
			,priority: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ordRecognitionAreaOfWorkRsp', 'priority'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordRecognitionAreaOfWorkRsp', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordRecognitionAreaOfWorkRsp', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
