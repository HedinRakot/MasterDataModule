define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataRolePermissionRsps',
		fields: {
			id: { type: "number", editable: false }
			,masterDataRoleId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataRolePermissionRsp', 'masterDataRoleId'), 
				                    validation: { required: true } }			
			,masterDataPermissionId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataRolePermissionRsp', 'masterDataPermissionId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('masterDataRolePermissionRsp', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('masterDataRolePermissionRsp', 'toDate'), 
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
