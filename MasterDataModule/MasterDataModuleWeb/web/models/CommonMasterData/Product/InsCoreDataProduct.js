define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsCoreDataProducts',
		fields: {
			id: { type: "number", editable: false }
			,productNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'productNumber'), 
				                    validation: { required: true, maxLength: 50 } }			
			,isNextInspectionProduct: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'isNextInspectionProduct'), 
				                    validation: { required: false } }			
			,isProvisionCostMayBeCalculated: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'isProvisionCostMayBeCalculated'), 
				                    validation: { required: false } }			
			,priceReportRequired: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'priceReportRequired'), 
				                    validation: { required: false } }			
			,insProductTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'insProductTypeId'), 
				                    validation: { required: true } }			
			,insProductObjectClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'insProductObjectClassId'), 
				                    validation: { required: false } }			
			,insProductObjectTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'insProductObjectTypeId'), 
				                    validation: { required: false } }			
			,insProductMaterialGroupId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'insProductMaterialGroupId'), 
				                    validation: { required: false } }			
			,insProductClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'insProductClassId'), 
				                    validation: { required: false } }			
			,insCoreDataProductGroupId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'insCoreDataProductGroupId'), 
				                    validation: { required: false } }			
			,isIngener: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'isIngener'), 
				                    validation: { required: false } }			
			,isProductive: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'isProductive'), 
				                    validation: { required: false } }			
			,isKmGeld: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'isKmGeld'), 
				                    validation: { required: false } }			
			,isOtherMaterial: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'isOtherMaterial'), 
				                    validation: { required: false } }			
			,isTrip: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'isTrip'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,reusageType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'reusageType'), 
				                    validation: { required: true } }			
			,insTaxCodeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'insTaxCodeId'), 
				                    validation: { required: false } }			
			,oldProductNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsCoreDataProduct', 'oldProductNumber'), 
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
