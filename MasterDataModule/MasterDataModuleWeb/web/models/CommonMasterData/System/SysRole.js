define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysRoles',
		fields: {
			id: { type: "number", editable: false }
			,roleNumber: { type: "number", 
			                        editable: Application.canTableItemBeEdit('sysRole', 'roleNumber'), 
				                    validation: { required: true } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysRole', 'name'), 
				                    validation: { required: false, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysRole', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
		}
	});
	return model;
});
