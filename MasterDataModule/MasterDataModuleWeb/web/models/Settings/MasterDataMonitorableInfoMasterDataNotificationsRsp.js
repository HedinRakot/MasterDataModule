define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataMonitorableInfoMasterDataNotificationsRsps',
		fields: {
			id: { type: "number", editable: false }
			,monitorableInfoType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataMonitorableInfoMasterDataNotificationsRsp', 'monitorableInfoType'), 
				                    validation: { required: true } }			
			,monitorableInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataMonitorableInfoMasterDataNotificationsRsp', 'monitorableInfoId'), 
				                    validation: { required: true } }			
			,masterDataNotificationsId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataMonitorableInfoMasterDataNotificationsRsp', 'masterDataNotificationsId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataMonitorableInfoMasterDataNotificationsRsp', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataMonitorableInfoMasterDataNotificationsRsp', 'toDate'), 
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
