define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsOpticalDefects',
    'l!t!TechnicalInspectionMasterData/FilterInsOpticalDefect',
    'l!t!TechnicalInspectionMasterData/InsOpticalDefectRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsOpticalDefect',
        editUrl: '#InsOpticalDefects',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
				{ field: 'isCustom', title: this.resources.isCustom , headerTitle: this.resources.isCustom, checkbox: true},
			];
		}
	});

	return view;
});
