define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/DriverSchools',
		fields: {
			id: { type: "number", editable: false }
			,driverSchoolNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('DriverSchool', 'driverSchoolNumber'), 
				                    validation: { required: true, maxLength: 50 } }			
			,ordCustomerId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('DriverSchool', 'ordCustomerId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('DriverSchool', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('DriverSchool', 'toDate'), 
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
