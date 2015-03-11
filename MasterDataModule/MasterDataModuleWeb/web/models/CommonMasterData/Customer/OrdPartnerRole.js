define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdPartnerRoles',
		fields: {
			id: { type: "number", editable: false }
			,sapQualifier: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordPartnerRole', 'sapQualifier'), 
				                    validation: { required: true, maxLength: 50 } }			
		}
	});
	return model;
});
