define([
	'base/base-object-grid-view',
'collections/DriverLicenceMasterData/ArgeVersions',
'l!t!DriverLicenceMasterData/FilterArgeVersion',
'l!t!DriverLicenceMasterData/ArgeVersionRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ArgeVersion',
        editUrl: '#ArgeVersions',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'programmName', title: this.resources.programmName },
				{ field: 'versionSystem', title: this.resources.versionSystem },
				{ field: 'expirationDate', title: this.resources.expirationDate , format: '{0:d}'},
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
