define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataNotificationsMasterDataSubscribersRsps',
		fields: {
			id: { type: "number", editable: false }
			,masterDataNotificationsId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotificationsMasterDataSubscribersRsp', 'masterDataNotificationsId'), 
				                    validation: { required: true } }			
			,masterDataSubscribersId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotificationsMasterDataSubscribersRsp', 'masterDataSubscribersId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotificationsMasterDataSubscribersRsp', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotificationsMasterDataSubscribersRsp', 'toDate'), 
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
