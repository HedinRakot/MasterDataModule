define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/LogTypeInfos',
		fields: {
			id: { type: "number", editable: false }
			,fileName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('LogTypeInfo', 'fileName'), 
				                    validation: { required: true, maxLength: 250 } }			
			,filePattern: { type: "string", 
			                        editable: Application.canTableItemBeEdit('LogTypeInfo', 'filePattern'), 
				                    validation: { required: true, maxLength: 250 } }			
			,filePath: { type: "string", 
			                        editable: Application.canTableItemBeEdit('LogTypeInfo', 'filePath'), 
				                    validation: { required: true } }			
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
