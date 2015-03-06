define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/InsCoreDataProducts',
    'l!t!CommonMasterData/Product/InsCoreDataProducts/FilterInsCoreDataProducts',
    'l!t!CommonMasterData/Product/InsCoreDataProducts/InsCoreDataProductsRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'insCoreDataProduct',
        editUrl: '#InsCoreDataProducts',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
		        { field: 'name', title: this.resources.name, width: '270px' },
		        { field: 'description', title: this.resources.description },
		        { field: 'productNumber', title: this.resources.productNumber, width: '220px' },
		        { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
		    ];
		}
	});

	return view;
});