define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Product/InsTaxCodes',
    'l!t!CommonMasterData/Product/FilterInsTaxCode',
    'l!t!CommonMasterData/Product/InsTaxCodeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsTaxCode',
        editUrl: '#InsTaxCodes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'taxCode', title: this.resources.taxCode },
			];
		}
	});

	return view;
});
