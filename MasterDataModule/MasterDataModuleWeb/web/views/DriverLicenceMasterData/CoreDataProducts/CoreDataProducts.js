define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/CoreDataProducts',
    'l!t!DriverLicenceMasterData/CoreDataProducts/FilterCoreDataProducts',
    'l!t!DriverLicenceMasterData/CoreDataProducts/CoreDataProductsRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'coreDataProduct',
        editUrl: '#CoreDataProducts',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
		        { field: 'name', title: this.resources.name, width: '370px' },
		        { field: 'description', title: this.resources.description },
		        { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
		    ];
		}
	});

	return view;
});