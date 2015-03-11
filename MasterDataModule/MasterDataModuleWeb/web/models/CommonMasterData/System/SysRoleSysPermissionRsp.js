define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysRoleSysPermissionRsps',
		fields: {
			id: { type: "number", editable: false }
			,sysRoleId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('sysRoleSysPermissionRsp', 'sysRoleId'), 
				                    validation: { required: true } }			
			,sysPermissionId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('sysRoleSysPermissionRsp', 'sysPermissionId'), 
				                    validation: { required: true } }			
		}
	});
	return model;
});
