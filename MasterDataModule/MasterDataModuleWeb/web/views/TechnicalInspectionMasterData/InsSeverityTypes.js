define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsSeverityTypes',
    'l!t!TechnicalInspectionMasterData/FilterInsSeverityType',
    'l!t!TechnicalInspectionMasterData/InsSeverityTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsSeverityType',
        editUrl: '#InsSeverityTypes',

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