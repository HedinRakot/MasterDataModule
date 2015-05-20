define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysCountries',
		fields: {
			id: { type: "number", editable: false }
			,sapId: { type: "string", 
			                        editable: Application.canTableItemBeEdit('SysCountry', 'sapId'), 
				                    validation: { required: true, maxLength: 10 } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('SysCountry', 'name'), 
				                    validation: { required: false, maxLength: 100 } }			
			,isEu: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('SysCountry', 'isEu'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('SysCountry', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('SysCountry', 'toDate'), 
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
