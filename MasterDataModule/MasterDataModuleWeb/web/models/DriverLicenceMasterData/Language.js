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
				                    validation: { required: true, maxLength: 10 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('language', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('language', 'toDate'), 
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
