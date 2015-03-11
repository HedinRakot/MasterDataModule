define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpCashPermissionTypes',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empCashPermissionType', 'name'), 
				                    validation: { required: true, maxLength: 10 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empCashPermissionType', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
		}
	});
	return model;
});
