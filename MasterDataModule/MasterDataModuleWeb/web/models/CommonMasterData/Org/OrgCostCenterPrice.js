define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgCostCenterPrices',
		fields: {
			id: { type: "number", editable: false }
			,insCoreDataProductId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'insCoreDataProductId'), 
				                    validation: { required: true } }			
			,salesOffice: { type: "string", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'salesOffice'), 
				                    validation: { required: true, maxLength: 10 } }			
			,minPrice: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'minPrice'), 
				                    validation: { required: false } }			
			,maxPrice: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'maxPrice'), 
				                    validation: { required: false } }			
			,standartPrice: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'standartPrice'), 
				                    validation: { required: false } }			
			,quantity: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'quantity'), 
				                    validation: { required: false } }			
			,unitOfMeasure: { type: "string", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'unitOfMeasure'), 
				                    validation: { required: false, maxLength: 10 } }			
			,sysCurrencyId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'sysCurrencyId'), 
				                    validation: { required: false } }			
			,changeAbilityType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'changeAbilityType'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrgCostCenterPrice', 'toDate'), 
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
