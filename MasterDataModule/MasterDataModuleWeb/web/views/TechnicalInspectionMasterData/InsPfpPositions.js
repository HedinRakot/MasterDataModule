define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsPfpPositions',
    'l!t!TechnicalInspectionMasterData/FilterInsPfpPosition',
    'l!t!TechnicalInspectionMasterData/InsPfpPositionRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsPfpPosition',
        editUrl: '#InsPfpPositions',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'text', title: this.resources.text },
			];
		}
	});

	return view;
});
