define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdOrderCancelationReasons',
		fields: {
			id: { type: "number", editable: false }
			,cancelationReasonText: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordOrderCancelationReason', 'cancelationReasonText'), 
				                    validation: { required: true, maxLength: 1024 } }			
		}
	});
	return model;
});
