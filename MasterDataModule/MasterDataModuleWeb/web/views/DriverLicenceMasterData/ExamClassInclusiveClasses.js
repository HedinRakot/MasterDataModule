define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamClassInclusiveClasses',
    'l!t!DriverLicenceMasterData/FilterExamClassInclusiveClass',
    'l!t!DriverLicenceMasterData/ExamClassInclusiveClassRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamClassInclusiveClass',
        editUrl: '#ExamClassInclusiveClasses',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'examClassIdInclusive', title: this.resources.examClassIdInclusive },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
				{ field: 'isConditional', title: this.resources.isConditional , headerTitle: this.resources.isConditional, checkbox: true},
			];
		}
	});

	return view;
});
