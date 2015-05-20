define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsCoreDataProductLocalizations',
		fields: {
			id: { type: "number", editable: false }
			,insCoreDataProductId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProductLocalization', 'insCoreDataProductId'), 
				                    validation: { required: true } }			
			,sysLanguageId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProductLocalization', 'sysLanguageId'), 
				                    validation: { required: true } }			
			,productName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProductLocalization', 'productName'), 
				                    validation: { required: true, maxLength: 250 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProductLocalization', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProductLocalization', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProductLocalization', 'toDate'), 
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
