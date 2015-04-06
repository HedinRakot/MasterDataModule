define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataNotificationsMasterDataSubscribersRsps',
		fields: {
			id: { type: "number", editable: false }
			,masterDataNotificationsId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataNotificationsMasterDataSubscribersRsp', 'masterDataNotificationsId'), 
				                    validation: { required: false } }			
			,masterDataSubscribersId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataNotificationsMasterDataSubscribersRsp', 'masterDataSubscribersId'), 
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
