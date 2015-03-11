define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgCostCenterPrices',
		fields: {
			id: { type: "number", editable: false }
			,insCoreDataProductId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgCostCenterPrice', 'insCoreDataProductId'), 
				                    validation: { required: true } }			
			,salesOffice: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgCostCenterPrice', 'salesOffice'), 
				                    validation: { required: true, maxLength: 10 } }			
			,minPrice: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgCostCenterPrice', 'minPrice'), 
				                    validation: { required: false } }			
			,maxPrice: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgCostCenterPrice', 'maxPrice'), 
				                    validation: { required: false } }			
			,standartPrice: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgCostCenterPrice', 'standartPrice'), 
				                    validation: { required: false } }			
			,quantity: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgCostCenterPrice', 'quantity'), 
				                    validation: { required: false } }			
			,unitOfMeasure: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgCostCenterPrice', 'unitOfMeasure'), 
				                    validation: { required: false, maxLength: 10 } }			
			,sysCurrencyId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgCostCenterPrice', 'sysCurrencyId'), 
				                    validation: { required: false } }			
			,changeAbilityType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgCostCenterPrice', 'changeAbilityType'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
