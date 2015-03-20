define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/DriverSchools',
    'l!t!DriverLicenceMasterData/FilterDriverSchool',
    'l!t!DriverLicenceMasterData/DriverSchoolRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'DriverSchool',
        editUrl: '#DriverSchools',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'driverSchoolNumber', title: this.resources.driverSchoolNumber },
				{ field: 'ordCustomerId', title: this.resources.ordCustomerId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
