define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsCoreDataProducts',
		fields: {
			id: { type: "number", editable: false }
			,productNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'productNumber'), 
				                    validation: { required: true, maxLength: 50 } }			
			,isNextInspectionProduct: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'isNextInspectionProduct'), 
				                    validation: { required: false } }			
			,isProvisionCostMayBeCalculated: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'isProvisionCostMayBeCalculated'), 
				                    validation: { required: false } }			
			,priceReportRequired: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'priceReportRequired'), 
				                    validation: { required: false } }			
			,insProductTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'insProductTypeId'), 
				                    validation: { required: true } }			
			,insProductObjectClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'insProductObjectClassId'), 
				                    validation: { required: false } }			
			,insProductObjectTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'insProductObjectTypeId'), 
				                    validation: { required: false } }			
			,insProductMaterialGroupId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'insProductMaterialGroupId'), 
				                    validation: { required: false } }			
			,insProductClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'insProductClassId'), 
				                    validation: { required: false } }			
			,insCoreDataProductGroupId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'insCoreDataProductGroupId'), 
				                    validation: { required: false } }			
			,isIngener: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'isIngener'), 
				                    validation: { required: false } }			
			,isProductive: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'isProductive'), 
				                    validation: { required: false } }			
			,isKmGeld: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'isKmGeld'), 
				                    validation: { required: false } }			
			,isOtherMaterial: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'isOtherMaterial'), 
				                    validation: { required: false } }			
			,isTrip: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'isTrip'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,reusageType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'reusageType'), 
				                    validation: { required: true } }			
			,insTaxCodeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'insTaxCodeId'), 
				                    validation: { required: false } }			
			,oldProductNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProduct', 'oldProductNumber'), 
				                    validation: { required: false, maxLength: 50 } }			
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
