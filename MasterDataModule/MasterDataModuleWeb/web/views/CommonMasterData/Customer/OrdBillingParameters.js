define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Customer/OrdBillingParameters',
    'l!t!CommonMasterData/Customer/FilterOrdBillingParameter',
    'l!t!CommonMasterData/Customer/OrdBillingParameterRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrdBillingParameter',
        editUrl: '#OrdBillingParameters',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'sapId', title: this.resources.sapId },
				{ field: 'description', title: this.resources.description },
			];
		}
	});

	return view;
});