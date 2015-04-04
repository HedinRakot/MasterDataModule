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
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
				{ field: 'name1', title: this.resources.name1 },
				{ field: 'streetHouseNumber', title: this.resources.streetHouseNumber },
				{ field: 'zipCode', title: this.resources.zipCode },
				{ field: 'city', title: this.resources.city },
			];
		}
	});

	return view;
});
