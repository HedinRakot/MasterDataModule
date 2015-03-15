define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamPossibleResults',
    'l!t!DriverLicenceMasterData/FilterExamPossibleResult',
    'l!t!DriverLicenceMasterData/ExamPossibleResultRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamPossibleResult',
        editUrl: '#ExamPossibleResults',

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
