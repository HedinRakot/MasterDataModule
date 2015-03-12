define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamConstraints',
    'l!t!DriverLicenceMasterData/FilterExamConstraint',
    'l!t!DriverLicenceMasterData/ExamConstraintRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamConstraint',
        editUrl: '#ExamConstraints',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
				{ field: 'constraintType', title: this.resources.constraintType },
			];
		}
	});

	return view;
});