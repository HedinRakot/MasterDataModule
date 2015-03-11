define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsSummaryFields',
    'l!t!TechnicalInspectionMasterData/FilterInsSummaryField',
    'l!t!TechnicalInspectionMasterData/InsSummaryFieldRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsSummaryField',
        editUrl: '#InsSummaryFields',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'description', title: this.resources.description },
			];
		}
	});

	return view;
});
