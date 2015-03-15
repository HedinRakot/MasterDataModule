define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdPartnerRoles',
		fields: {
			id: { type: "number", editable: false }
			,sapQualifier: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordPartnerRole', 'sapQualifier'), 
				                    validation: { required: true, maxLength: 50 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordPartnerRole', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ordPartnerRole', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
