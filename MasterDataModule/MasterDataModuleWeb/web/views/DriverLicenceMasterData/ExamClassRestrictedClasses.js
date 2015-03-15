define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamClassRestrictedClasses',
    'l!t!DriverLicenceMasterData/FilterExamClassRestrictedClass',
    'l!t!DriverLicenceMasterData/ExamClassRestrictedClassRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamClassRestrictedClass',
        editUrl: '#ExamClassRestrictedClasses',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'examClassIdRestricted', title: this.resources.examClassIdRestricted },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
