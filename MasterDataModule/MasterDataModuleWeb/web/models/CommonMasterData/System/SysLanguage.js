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
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('sysLanguage', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('sysLanguage', 'toDate'), 
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
