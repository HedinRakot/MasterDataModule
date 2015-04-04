define([
	'base/base-object-grid-view',
'collections/DriverLicenceMasterData/ExamClasses',
'l!t!DriverLicenceMasterData/FilterExamClass',
'l!t!DriverLicenceMasterData/ExamClassRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamClass',
        editUrl: '#ExamClasses',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
				{ field: 'sortOrder', title: this.resources.sortOrder },
			];
		}

	});

	return view;
});
