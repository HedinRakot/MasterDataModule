define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysRoles',
		fields: {
			id: { type: "number", editable: false }
			,roleNumber: { type: "number", 
			                        editable: Application.canTableItemBeEdit('SysRole', 'roleNumber'), 
				                    validation: { required: true } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('SysRole', 'name'), 
				                    validation: { required: false, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('SysRole', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('SysRole', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('SysRole', 'toDate'), 
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
