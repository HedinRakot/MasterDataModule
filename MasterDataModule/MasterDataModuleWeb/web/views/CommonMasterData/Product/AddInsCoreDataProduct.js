define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsCoreDataProductRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsCoreDataProduct',
        actionUrl: '#InsCoreDataProducts',

		bindings: function () {

            var self = this;
            var result = {
			'#productNumber': 'productNumber',
			'#isNextInspectionProduct': 'isNextInspectionProduct',
			'#isProvisionCostMayBeCalculated': 'isProvisionCostMayBeCalculated',
			'#priceReportRequired': 'priceReportRequired',
			'#insProductTypeId': 'insProductTypeId',
			'#insProductObjectClassId': 'insProductObjectClassId',
			'#insProductObjectTypeId': 'insProductObjectTypeId',
			'#insProductMaterialGroupId': 'insProductMaterialGroupId',
			'#insProductClassId': 'insProductClassId',
			'#insCoreDataProductGroupId': 'insCoreDataProductGroupId',
			'#isIngener': 'isIngener',
			'#isProductive': 'isProductive',
			'#isKmGeld': 'isKmGeld',
			'#isOtherMaterial': 'isOtherMaterial',
			'#isTrip': 'isTrip',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#reusageType': 'reusageType',
			'#insTaxCodeId': 'insTaxCodeId',
			'#oldProductNumber': 'oldProductNumber',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'productNumber');
			this.disableInput(this, 'isNextInspectionProduct');
			this.disableInput(this, 'isProvisionCostMayBeCalculated');
			this.disableInput(this, 'priceReportRequired');
			this.disableInput(this, 'insProductTypeId', 'numeric');
			this.disableInput(this, 'insProductObjectClassId', 'numeric');
			this.disableInput(this, 'insProductObjectTypeId', 'numeric');
			this.disableInput(this, 'insProductMaterialGroupId', 'numeric');
			this.disableInput(this, 'insProductClassId', 'numeric');
			this.disableInput(this, 'insCoreDataProductGroupId', 'numeric');
			this.disableInput(this, 'isIngener');
			this.disableInput(this, 'isProductive', 'numeric');
			this.disableInput(this, 'isKmGeld');
			this.disableInput(this, 'isOtherMaterial');
			this.disableInput(this, 'isTrip');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'reusageType', 'numeric');
			this.disableInput(this, 'insTaxCodeId', 'numeric');
			this.disableInput(this, 'oldProductNumber');

            return this;
        }
    });

    return view;
});
