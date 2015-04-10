define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/DriverSchoolInfos',
		fields: {
			id: { type: "number", editable: false }
			,schoolInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('DriverSchoolInfo', 'schoolInfoId'), 
				                    validation: { required: true } }			
			,driverSchoolId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('DriverSchoolInfo', 'driverSchoolId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('DriverSchoolInfo', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('DriverSchoolInfo', 'toDate'), 
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
