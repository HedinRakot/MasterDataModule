define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgInformation',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInformation', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,value: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgInformation', 'value'), 
				                    validation: { required: false, maxLength: 250 } }			
		}
	});
	return model;
});
