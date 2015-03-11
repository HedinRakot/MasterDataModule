define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamRecognitionTypes',
    'l!t!DriverLicenceMasterData/FilterExamRecognitionType',
    'l!t!DriverLicenceMasterData/ExamRecognitionTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamRecognitionType',
        editUrl: '#ExamRecognitionTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
			];
		}
	});

	return view;
});
