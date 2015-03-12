define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Product/InsProductMaterialGroups',
    'l!t!CommonMasterData/Product/FilterInsProductMaterialGroup',
    'l!t!CommonMasterData/Product/InsProductMaterialGroupRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsProductMaterialGroup',
        editUrl: '#InsProductMaterialGroups',

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