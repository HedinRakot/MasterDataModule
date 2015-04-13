define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysTables',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('SysTable', 'name'), 
				                    validation: { required: true, maxLength: 128 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('SysTable', 'description'), 
				                    validation: { required: false, maxLength: 256 } }			
			,editMode: { type: "number", 
			                        editable: Application.canTableItemBeEdit('SysTable', 'editMode'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('SysTable', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('SysTable', 'toDate'), 
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
