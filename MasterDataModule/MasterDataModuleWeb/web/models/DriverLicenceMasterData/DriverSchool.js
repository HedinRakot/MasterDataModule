define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/DriverSchools',
		fields: {
			id: { type: "number", editable: false }
			,driverSchoolNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('driverSchool', 'driverSchoolNumber'), 
				                    validation: { required: true, maxLength: 50 } }			
			,ordCustomerId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('driverSchool', 'ordCustomerId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('driverSchool', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('driverSchool', 'toDate'), 
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
