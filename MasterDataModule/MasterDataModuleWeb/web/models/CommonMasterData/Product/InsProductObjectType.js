define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsProductObjectTypes',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsProductObjectType', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,sapId: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsProductObjectType', 'sapId'), 
				                    validation: { required: true, maxLength: 10 } }			
			,isAuNecessary: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsProductObjectType', 'isAuNecessary'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsProductObjectType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsProductObjectType', 'toDate'), 
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
