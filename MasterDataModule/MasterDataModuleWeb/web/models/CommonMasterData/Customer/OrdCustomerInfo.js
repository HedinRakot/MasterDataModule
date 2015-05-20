define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdCustomerInfos',
		fields: {
			id: { type: "number", editable: false }
			,textValue: { type: "string", 
			                        editable: Application.canTableItemBeEdit('OrdCustomerInfo', 'textValue'), 
				                    validation: { required: true, maxLength: 512 } }			
			,numberValue: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrdCustomerInfo', 'numberValue'), 
				                    validation: { required: false } }			
			,infoType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrdCustomerInfo', 'infoType'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrdCustomerInfo', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrdCustomerInfo', 'toDate'), 
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
