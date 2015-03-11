define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamStations',
    'l!t!DriverLicenceMasterData/FilterExamStation',
    'l!t!DriverLicenceMasterData/ExamStationRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamStation',
        editUrl: '#ExamStations',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'ordFederalStateId', title: this.resources.ordFederalStateId },
				{ field: 'place', title: this.resources.place },
				{ field: 'description', title: this.resources.description },
				{ field: 'sortOrder', title: this.resources.sortOrder },
			];
		}
	});

	return view;
});
