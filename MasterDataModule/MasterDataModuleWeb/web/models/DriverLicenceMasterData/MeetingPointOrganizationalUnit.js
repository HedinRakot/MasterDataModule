define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MeetingPointOrganizationalUnits',
		fields: {
			id: { type: "number", editable: false }
			,meetingPointId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('meetingPointOrganizationalUnit', 'meetingPointId'), 
				                    validation: { required: true } }			
			,orgOrganizationalUnitId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('meetingPointOrganizationalUnit', 'orgOrganizationalUnitId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('meetingPointOrganizationalUnit', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('meetingPointOrganizationalUnit', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});