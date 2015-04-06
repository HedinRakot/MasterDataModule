define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataMonitorableInfoMasterDataNotificationsRsps',
		fields: {
			id: { type: "number", editable: false }
			,monitorableInfoType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataMonitorableInfoMasterDataNotificationsRsp', 'monitorableInfoType'), 
				                    validation: { required: false } }			
			,monitorableInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataMonitorableInfoMasterDataNotificationsRsp', 'monitorableInfoId'), 
				                    validation: { required: false } }			
			,masterDataNotificationsId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataMonitorableInfoMasterDataNotificationsRsp', 'masterDataNotificationsId'), 
				                    validation: { required: false } }			
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
