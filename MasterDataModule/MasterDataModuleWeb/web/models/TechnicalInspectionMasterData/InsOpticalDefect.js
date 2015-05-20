define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsOpticalDefects',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsOpticalDefect', 'name'), 
				                    validation: { required: true, maxLength: 20 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsOpticalDefect', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,isCustom: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsOpticalDefect', 'isCustom'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsOpticalDefect', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsOpticalDefect', 'toDate'), 
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
