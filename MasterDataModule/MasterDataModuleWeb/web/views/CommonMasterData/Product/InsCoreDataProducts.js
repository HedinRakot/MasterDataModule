define([
	'base/base-object-grid-view',
'collections/CommonMasterData/Product/InsCoreDataProducts',
'l!t!CommonMasterData/Product/FilterInsCoreDataProduct',
'l!t!CommonMasterData/Product/InsCoreDataProductRelationships'
,'CommonMasterData/Product/Custom.InsCoreDataProduct'
], function (BaseView, Collection, FilterView, DetailView, CustomColumns) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsCoreDataProduct',
        editUrl: '#InsCoreDataProducts',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return $.merge( CustomColumns(),
[
				{ field: 'productNumber', title: this.resources.productNumber },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
				{ field: 'oldProductNumber', title: this.resources.oldProductNumber },
			]);
		}
	});

	return view;
});
