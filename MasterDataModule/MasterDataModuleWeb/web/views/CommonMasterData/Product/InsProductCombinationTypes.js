define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Product/InsProductCombinationTypes',
    'l!t!CommonMasterData/Product/FilterInsProductCombinationType',
    'l!t!CommonMasterData/Product/InsProductCombinationTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsProductCombinationType',
        editUrl: '#InsProductCombinationTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'description', title: this.resources.description },
			];
		}
	});

	return view;
});
