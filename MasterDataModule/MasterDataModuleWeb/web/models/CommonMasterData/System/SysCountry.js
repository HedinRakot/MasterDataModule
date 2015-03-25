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
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('sysCountry', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('sysCountry', 'toDate'), 
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
