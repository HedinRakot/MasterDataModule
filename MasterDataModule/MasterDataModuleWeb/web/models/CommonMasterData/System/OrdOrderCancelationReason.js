define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdOrderCancelationReasons',
		fields: {
			id: { type: "number", editable: false }
			,cancelationReasonText: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordOrderCancelationReason', 'cancelationReasonText'), 
				                    validation: { required: true, maxLength: 1024 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordOrderCancelationReason', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordOrderCancelationReason', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
