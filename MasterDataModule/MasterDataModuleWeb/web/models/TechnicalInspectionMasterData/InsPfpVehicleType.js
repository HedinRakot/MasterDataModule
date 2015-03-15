define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsPfpVehicleTypes',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insPfpVehicleType', 'description'), 
				                    validation: { required: true, maxLength: 50 } }			
			,imageFileName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insPfpVehicleType', 'imageFileName'), 
				                    validation: { required: false, maxLength: 50 } }			
			,isPolygonDataValid: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insPfpVehicleType', 'isPolygonDataValid'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insPfpVehicleType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insPfpVehicleType', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
