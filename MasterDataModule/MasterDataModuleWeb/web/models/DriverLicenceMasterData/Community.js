define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/Communities',
		fields: {
			id: { type: "number", editable: false }
			,driverSchoolId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('Community', 'driverSchoolId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('Community', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('Community', 'toDate'), 
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
