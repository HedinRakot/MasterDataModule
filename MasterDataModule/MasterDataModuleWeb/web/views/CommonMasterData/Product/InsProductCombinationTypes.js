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
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
