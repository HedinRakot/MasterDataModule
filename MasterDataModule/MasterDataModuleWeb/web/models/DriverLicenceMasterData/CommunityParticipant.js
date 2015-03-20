define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/CommunityParticipants',
		fields: {
			id: { type: "number", editable: false }
			,driverSchoolIdParticipant: { type: "number", 
			                        editable: Application.canTableItemBeEdit('communityParticipant', 'driverSchoolIdParticipant'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('communityParticipant', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('communityParticipant', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,driverSchoolIdLead: { type: "number", 
			                        editable: Application.canTableItemBeEdit('communityParticipant', 'driverSchoolIdLead'), 
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
