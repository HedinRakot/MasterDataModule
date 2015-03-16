define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamClassRequiredClasses',
    'l!t!DriverLicenceMasterData/FilterExamClassRequiredClass',
    'l!t!DriverLicenceMasterData/ExamClassRequiredClassRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamClassRequiredClass',
        editUrl: '#ExamClassRequiredClasses',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'examClassIdRequired', title: this.resources.examClassIdRequired },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
