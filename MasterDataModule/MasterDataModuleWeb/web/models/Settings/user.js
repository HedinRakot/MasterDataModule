define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/Users',
		fields: {
			id: { type: "number", editable: false }
			,masterDataRoleId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('user', 'masterDataRoleId'), 
				                    validation: { required: true } }			
			,login: { type: "string", 
			                        editable: Application.canTableItemBeEdit('user', 'login'), 
				                    validation: { required: true, maxLength: 128 } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('user', 'name'), 
				                    validation: { required: true, maxLength: 256 } }			
			,password: { type: "string", 
			                        editable: Application.canTableItemBeEdit('user', 'password'), 
				                    validation: { required: true, maxLength: 128 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('user', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('user', 'toDate'), 
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
