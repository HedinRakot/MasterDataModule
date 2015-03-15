define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/Communities',
		fields: {
			id: { type: "number", editable: false }
			,driverSchoolId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('community', 'driverSchoolId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('community', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('community', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
