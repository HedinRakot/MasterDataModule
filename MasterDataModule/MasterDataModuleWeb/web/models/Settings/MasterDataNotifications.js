define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataNotifications',
		fields: {
			id: { type: "number", editable: false }
			,notificationType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataNotifications', 'notificationType'), 
				                    validation: { required: false } }			
			,isAlertOn: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('masterDataNotifications', 'isAlertOn'), 
				                    validation: { required: false } }			
			,alertCheckStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataNotifications', 'alertCheckStatus'), 
				                    validation: { required: false } }			
			,alertAttemptCount: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataNotifications', 'alertAttemptCount'), 
				                    validation: { required: false } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataNotifications', 'message'), 
				                    validation: { required: false, maxLength: 0 } }			
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
