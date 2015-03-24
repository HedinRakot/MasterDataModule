define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/Roles',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('role', 'name'), 
				                    validation: { required: true, maxLength: 256 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('role', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('role', 'toDate'), 
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
