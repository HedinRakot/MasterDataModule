define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysLanguages',
		fields: {
			id: { type: "number", editable: false }
			,sapId: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysLanguage', 'sapId'), 
				                    validation: { required: true, maxLength: 10 } }			
			,sapIdIso: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysLanguage', 'sapIdIso'), 
				                    validation: { required: false, maxLength: 10 } }			
			,resourceFileName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysLanguage', 'resourceFileName'), 
				                    validation: { required: false, maxLength: 10 } }			
			,isAvailable: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('sysLanguage', 'isAvailable'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});