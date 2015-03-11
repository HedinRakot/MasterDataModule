define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/Languages',
		fields: {
			id: { type: "number", editable: false }
			,sysLanguageId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('language', 'sysLanguageId'), 
				                    validation: { required: true } }			
			,oldAbbr: { type: "string", 
			                        editable: Application.canTableItemBeEdit('language', 'oldAbbr'), 
				                    validation: { required: false, maxLength: 10 } }			
		}
	});
	return model;
});
