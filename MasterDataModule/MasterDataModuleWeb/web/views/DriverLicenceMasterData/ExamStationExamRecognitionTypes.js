define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamStationExamRecognitionTypes',
    'l!t!DriverLicenceMasterData/FilterExamStationExamRecognitionType',
    'l!t!DriverLicenceMasterData/ExamStationExamRecognitionTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamStationExamRecognitionType',
        editUrl: '#ExamStationExamRecognitionTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'examRecognitionTypeId', title: this.resources.examRecognitionTypeId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
