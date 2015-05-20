define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdOrderCancelationReasons',
		fields: {
			id: { type: "number", editable: false }
			,cancelationReasonText: { type: "string", 
			                        editable: Application.canTableItemBeEdit('OrdOrderCancelationReason', 'cancelationReasonText'), 
				                    validation: { required: true, maxLength: 1024 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrdOrderCancelationReason', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrdOrderCancelationReason', 'toDate'), 
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
