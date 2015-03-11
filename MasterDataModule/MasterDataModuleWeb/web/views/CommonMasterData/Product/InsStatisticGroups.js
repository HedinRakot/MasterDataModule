define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Product/InsStatisticGroups',
    'l!t!CommonMasterData/Product/FilterInsStatisticGroup',
    'l!t!CommonMasterData/Product/InsStatisticGroupRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsStatisticGroup',
        editUrl: '#InsStatisticGroups',

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
