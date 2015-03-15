define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Org/OrgCostCenterPriceRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrgCostCenterPrice',
        actionUrl: '#OrgCostCenterPrices',

		bindings: {
			'#insCoreDataProductId': 'insCoreDataProductId',
			'#salesOffice': 'salesOffice',
			'#minPrice': 'minPrice',
			'#maxPrice': 'maxPrice',
			'#standartPrice': 'standartPrice',
			'#quantity': 'quantity',
			'#unitOfMeasure': 'unitOfMeasure',
			'#sysCurrencyId': 'sysCurrencyId',
			'#changeAbilityType': 'changeAbilityType',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'insCoreDataProductId', 'numeric');
			this.disableInput(this, 'salesOffice');
			this.disableInput(this, 'minPrice', 'numeric');
			this.disableInput(this, 'maxPrice', 'numeric');
			this.disableInput(this, 'standartPrice', 'numeric');
			this.disableInput(this, 'quantity', 'numeric');
			this.disableInput(this, 'unitOfMeasure');
			this.disableInput(this, 'sysCurrencyId', 'numeric');
			this.disableInput(this, 'changeAbilityType', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
