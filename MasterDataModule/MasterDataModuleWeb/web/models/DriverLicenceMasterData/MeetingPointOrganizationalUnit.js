define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MeetingPointOrganizationalUnits',
		fields: {
			id: { type: "number", editable: false }
			,meetingPointId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MeetingPointOrganizationalUnit', 'meetingPointId'), 
				                    validation: { required: true } }			
			,orgOrganizationalUnitId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MeetingPointOrganizationalUnit', 'orgOrganizationalUnitId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MeetingPointOrganizationalUnit', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MeetingPointOrganizationalUnit', 'toDate'), 
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
