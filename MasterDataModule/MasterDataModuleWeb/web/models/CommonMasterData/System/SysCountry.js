define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysCountries',
		fields: {
			id: { type: "number", editable: false }
			,sapId: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysCountry', 'sapId'), 
				                    validation: { required: true, maxLength: 10 } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysCountry', 'name'), 
				                    validation: { required: false, maxLength: 100 } }			
			,isEu: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('sysCountry', 'isEu'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
