define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsInspectionSteps',
    'l!t!TechnicalInspectionMasterData/FilterInsInspectionStep',
    'l!t!TechnicalInspectionMasterData/InsInspectionStepRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsInspectionStep',
        editUrl: '#InsInspectionSteps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'description', title: this.resources.description },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
