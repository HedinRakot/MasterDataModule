define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysTables',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysTable', 'description'), 
				                    validation: { required: false, maxLength: 256 } }			
			,editMode: { type: "number", 
			                        editable: Application.canTableItemBeEdit('sysTable', 'editMode'), 
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
