define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SiteInfosWithLastResults',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('SiteInfosWithLastResult', 'name'), 
				                    validation: { required: false } }			
			,lastResult: { type: "number", 
			                        editable: Application.canTableItemBeEdit('SiteInfosWithLastResult', 'lastResult'), 
				                    validation: { required: false } }			
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
