define([
'base/base-object-grid-view',
'collections/DriverLicenceMasterData/Holidays',
'l!t!DriverLicenceMasterData/FilterHoliday',
'l!t!DriverLicenceMasterData/HolidayRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'Holiday',
        editUrl: '#Holidays',
		addNewModelInline: true,
		showAddButton: true,
		showEditButton: true,
		showDeleteButton: true,

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'name', title: this.resources.name },
				{ field: 'date', title: this.resources.date , format: '{0:d}'},
			];
		}

	});

	return view;
});
