define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsPfpPositions',
		fields: {
			id: { type: "number", editable: false }
			,text: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsPfpPosition', 'text'), 
				                    validation: { required: true, maxLength: 250 } }			
			,topId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsPfpPosition', 'topId'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsPfpPosition', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsPfpPosition', 'toDate'), 
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
