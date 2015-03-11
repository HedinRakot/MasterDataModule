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
				{ field: 'insInspectionStepId', title: this.resources.insInspectionStepId },
				{ field: 'isMandatory', title: this.resources.isMandatory , headerTitle: this.resources.isMandatory, checkbox: true},
			];
		}
	});

	return view;
});
