define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/CoreDataProductLocalizations',
		fields: {
			id: { type: "number", editable: false }
			,coreDataProductId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'coreDataProductId'), 
				                    validation: { required: true } }			
			,sysLanguageId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'sysLanguageId'), 
				                    validation: { required: true } }			
			,productName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'productName'), 
				                    validation: { required: true, maxLength: 250 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
