define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamClassMaps',
    'l!t!DriverLicenceMasterData/FilterExamClassMap',
    'l!t!DriverLicenceMasterData/ExamClassMapRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamClassMap',
        editUrl: '#ExamClassMaps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'examClassIdOld', title: this.resources.examClassIdOld },
				{ field: 'examClassIdActual', title: this.resources.examClassIdActual },
			];
		}
	});

	return view;
});
