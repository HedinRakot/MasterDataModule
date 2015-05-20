define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsPfpVehicleTypes',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsPfpVehicleType', 'description'), 
				                    validation: { required: true, maxLength: 50 } }			
			,imageFileName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsPfpVehicleType', 'imageFileName'), 
				                    validation: { required: false, maxLength: 50 } }			
			,isPolygonDataValid: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsPfpVehicleType', 'isPolygonDataValid'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsPfpVehicleType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsPfpVehicleType', 'toDate'), 
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
