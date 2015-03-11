define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Org/OrgCostCenterPrices',
    'l!t!CommonMasterData/Org/FilterOrgCostCenterPrice',
    'l!t!CommonMasterData/Org/OrgCostCenterPriceRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrgCostCenterPrice',
        editUrl: '#OrgCostCenterPrices',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'insCoreDataProductId', title: this.resources.insCoreDataProductId },
				{ field: 'salesOffice', title: this.resources.salesOffice },
				{ field: 'minPrice', title: this.resources.minPrice },
				{ field: 'maxPrice', title: this.resources.maxPrice },
				{ field: 'standartPrice', title: this.resources.standartPrice },
				{ field: 'quantity', title: this.resources.quantity },
				{ field: 'unitOfMeasure', title: this.resources.unitOfMeasure },
				{ field: 'sysCurrencyId', title: this.resources.sysCurrencyId },
				{ field: 'changeAbilityType', title: this.resources.changeAbilityType },
			];
		}
	});

	return view;
});
