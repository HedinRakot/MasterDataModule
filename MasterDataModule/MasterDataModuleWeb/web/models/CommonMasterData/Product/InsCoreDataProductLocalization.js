define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsCoreDataProductLocalizations',
		fields: {
			id: { type: "number", editable: false }
			,insCoreDataProductId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'insCoreDataProductId'), 
				                    validation: { required: true } }			
			,sysLanguageId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'sysLanguageId'), 
				                    validation: { required: true } }			
			,productName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'productName'), 
				                    validation: { required: true, maxLength: 250 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
