define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamConstraintExamClasses',
    'l!t!DriverLicenceMasterData/FilterExamConstraintExamClass',
    'l!t!DriverLicenceMasterData/ExamConstraintExamClassRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamConstraintExamClass',
        editUrl: '#ExamConstraintExamClasses',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'examClassId', title: this.resources.examClassId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
