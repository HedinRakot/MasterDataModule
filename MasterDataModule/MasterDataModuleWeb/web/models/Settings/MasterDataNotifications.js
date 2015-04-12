define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataNotifications',
		fields: {
			id: { type: "number", editable: false }
			,notificationType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'notificationType'), 
				                    validation: { required: true } }			
			,isAlertOn: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'isAlertOn'), 
				                    validation: { required: false } }			
			,alertCheckStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'alertCheckStatus'), 
				                    validation: { required: true } }			
			,alertAttemptCount: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'alertAttemptCount'), 
				                    validation: { required: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'message'), 
				                    validation: { required: true } }			
			,subject: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataNotifications', 'subject'), 
				                    validation: { required: true } }			
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
