define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/CoreDataProductLocalizations',
		fields: {
			id: { type: "number", editable: false }
			,coreDataProductId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductLocalization', 'coreDataProductId'), 
				                    validation: { required: true } }			
			,sysLanguageId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductLocalization', 'sysLanguageId'), 
				                    validation: { required: true } }			
			,productName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductLocalization', 'productName'), 
				                    validation: { required: true, maxLength: 250 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductLocalization', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductLocalization', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductLocalization', 'toDate'), 
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
