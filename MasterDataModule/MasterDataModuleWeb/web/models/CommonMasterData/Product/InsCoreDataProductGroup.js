define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsCoreDataProductGroups',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProductGroup', 'name'), 
				                    validation: { required: true, maxLength: 250 } }			
			,defaultDuration: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProductGroup', 'defaultDuration'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProductGroup', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProductGroup', 'toDate'), 
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
