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
				                    validation: { required: true, maxLength: 500 } }			
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
