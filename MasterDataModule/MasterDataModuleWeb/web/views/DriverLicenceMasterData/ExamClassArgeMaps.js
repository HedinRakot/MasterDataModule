define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamClassArgeMaps',
    'l!t!DriverLicenceMasterData/FilterExamClassArgeMap',
    'l!t!DriverLicenceMasterData/ExamClassArgeMapRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamClassArgeMap',
        editUrl: '#ExamClassArgeMaps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'examNameArge', title: this.resources.examNameArge },
			];
		}
	});

	return view;
});
