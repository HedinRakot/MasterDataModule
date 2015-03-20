define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/CoreDataProducts',
    'l!t!DriverLicenceMasterData/FilterCoreDataProduct',
    'l!t!DriverLicenceMasterData/CoreDataProductRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'CoreDataProduct',
        editUrl: '#CoreDataProducts',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
				{ field: 'feProductNumber', title: this.resources.feProductNumber },
			];
		}
	});

	return view;
});
