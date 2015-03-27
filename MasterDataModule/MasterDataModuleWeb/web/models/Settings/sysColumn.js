define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysColumns',
		fields: {
			id: { type: "number", editable: false }
			,sysTableId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('sysColumn', 'sysTableId'), 
				                    validation: { required: false } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysColumn', 'name'), 
				                    validation: { required: true, maxLength: 128 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysColumn', 'description'), 
				                    validation: { required: false, maxLength: 256 } }			
			,readOnly: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('sysColumn', 'readOnly'), 
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
