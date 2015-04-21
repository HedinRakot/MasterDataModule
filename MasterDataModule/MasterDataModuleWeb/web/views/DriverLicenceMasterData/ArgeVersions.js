define([
'base/base-object-grid-view',
'collections/DriverLicenceMasterData/ArgeVersions',
'l!t!DriverLicenceMasterData/FilterArgeVersion'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'ArgeVersion',
        editUrl: '#ArgeVersions',
		addNewModelInline: true,
		showAddButton: true,
		showEditButton: true,
		showDeleteButton: true,

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'programmName', title: this.resources.programmName },
				{ field: 'versionSystem', title: this.resources.versionSystem },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
