define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataNotifications',
		fields: {
			id: { type: "number", editable: false }
			,notificationType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'notificationType'), 
				                    validation: { required: false } }			
			,isAlertOn: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'isAlertOn'), 
				                    validation: { required: false } }			
			,alertCheckStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'alertCheckStatus'), 
				                    validation: { required: false } }			
			,alertAttemptCount: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'alertAttemptCount'), 
				                    validation: { required: false } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'message'), 
				                    validation: { required: false } }			
			,subject: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'subject'), 
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
