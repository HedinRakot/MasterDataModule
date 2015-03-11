define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MessageLocalizations',
		fields: {
			id: { type: "number", editable: false }
			,validationErrorNumber: { type: "number", 
			                        editable: Application.canTableItemBeEdit('messageLocalization', 'validationErrorNumber'), 
				                    validation: { required: true } }			
			,sysLanguageId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('messageLocalization', 'sysLanguageId'), 
				                    validation: { required: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('messageLocalization', 'message'), 
				                    validation: { required: false, maxLength: 500 } }			
		}
	});
	return model;
});
