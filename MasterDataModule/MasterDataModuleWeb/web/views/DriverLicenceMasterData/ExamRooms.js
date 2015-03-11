define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamRooms',
    'l!t!DriverLicenceMasterData/FilterExamRoom',
    'l!t!DriverLicenceMasterData/ExamRoomRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamRoom',
        editUrl: '#ExamRooms',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'roomNumber', title: this.resources.roomNumber },
				{ field: 'placeAmount', title: this.resources.placeAmount },
				{ field: 'orgOrganizationalUnitId', title: this.resources.orgOrganizationalUnitId },
				{ field: 'name1', title: this.resources.name1 },
				{ field: 'name2', title: this.resources.name2 },
				{ field: 'name3', title: this.resources.name3 },
				{ field: 'streetHouseNumber', title: this.resources.streetHouseNumber },
				{ field: 'zipCode', title: this.resources.zipCode },
				{ field: 'zipBox', title: this.resources.zipBox },
				{ field: 'box', title: this.resources.box },
				{ field: 'city', title: this.resources.city },
				{ field: 'phone1', title: this.resources.phone1 },
				{ field: 'fax', title: this.resources.fax },
				{ field: 'email', title: this.resources.email },
				{ field: 'sysCountryId', title: this.resources.sysCountryId },
			];
		}
	});

	return view;
});
