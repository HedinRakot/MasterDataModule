define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsProductClassGroups',
    'l!t!TechnicalInspectionMasterData/FilterInsProductClassGroup',
    'l!t!TechnicalInspectionMasterData/InsProductClassGroupRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsProductClassGroup',
        editUrl: '#InsProductClassGroups',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'description', title: this.resources.description },
				{ field: 'sapId', title: this.resources.sapId },
			];
		}
	});

	return view;
});