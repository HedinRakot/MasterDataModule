define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Product/InsProductTypes',
    'l!t!CommonMasterData/Product/FilterInsProductType',
    'l!t!CommonMasterData/Product/InsProductTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsProductType',
        editUrl: '#InsProductTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
			];
		}
	});

	return view;
});
