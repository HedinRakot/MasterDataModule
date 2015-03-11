define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/Communities',
		fields: {
			id: { type: "number", editable: false }
			,driverSchoolId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('community', 'driverSchoolId'), 
				                    validation: { required: true } }			
		}
	});
	return model;
});
