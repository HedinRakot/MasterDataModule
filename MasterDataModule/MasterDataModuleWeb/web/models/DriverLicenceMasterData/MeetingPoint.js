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
		}
	});
	return model;
});
