define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysLocations',
		fields: {
			id: { type: "number", editable: false }
			,locationCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysLocation', 'locationCode'), 
				                    validation: { required: true, maxLength: 10 } }			
			,locationName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysLocation', 'locationName'), 
				                    validation: { required: false, maxLength: 100 } }			
			,sysCountryId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('sysLocation', 'sysCountryId'), 
				                    validation: { required: false } }			
			,ordFederalStateId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('sysLocation', 'ordFederalStateId'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('sysLocation', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('sysLocation', 'toDate'), 
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
