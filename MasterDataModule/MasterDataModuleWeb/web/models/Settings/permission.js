define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/Permissions',
		fields: {
			id: { type: "number", editable: false }
			,systemName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('permission', 'systemName'), 
				                    validation: { required: false, maxLength: 256 } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('permission', 'name'), 
				                    validation: { required: true, maxLength: 256 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('permission', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('permission', 'toDate'), 
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
