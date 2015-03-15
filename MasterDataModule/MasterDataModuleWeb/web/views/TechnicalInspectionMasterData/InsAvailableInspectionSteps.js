define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsAvailableInspectionSteps',
    'l!t!TechnicalInspectionMasterData/FilterInsAvailableInspectionStep',
    'l!t!TechnicalInspectionMasterData/InsAvailableInspectionStepRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsAvailableInspectionStep',
        editUrl: '#InsAvailableInspectionSteps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'isMandatory', title: this.resources.isMandatory , headerTitle: this.resources.isMandatory, checkbox: true},
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
