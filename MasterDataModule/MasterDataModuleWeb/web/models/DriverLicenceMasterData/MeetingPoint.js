define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MeetingPoints',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('meetingPoint', 'name'), 
				                    validation: { required: true, maxLength: 100 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('meetingPoint', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('meetingPoint', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('meetingPoint', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
