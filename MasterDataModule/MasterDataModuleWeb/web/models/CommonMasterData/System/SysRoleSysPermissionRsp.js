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
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('sysRoleSysPermissionRsp', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('sysRoleSysPermissionRsp', 'toDate'), 
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
