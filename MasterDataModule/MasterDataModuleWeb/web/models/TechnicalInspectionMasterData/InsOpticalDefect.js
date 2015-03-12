define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsOpticalDefects',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insOpticalDefect', 'name'), 
				                    validation: { required: true, maxLength: 20 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insOpticalDefect', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,isCustom: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insOpticalDefect', 'isCustom'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});