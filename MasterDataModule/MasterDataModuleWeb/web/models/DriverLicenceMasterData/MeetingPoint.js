define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MeetingPoints',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MeetingPoint', 'name'), 
				                    validation: { required: true, maxLength: 100 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MeetingPoint', 'description'), 
				                    validation: { required: true, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MeetingPoint', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MeetingPoint', 'toDate'), 
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
