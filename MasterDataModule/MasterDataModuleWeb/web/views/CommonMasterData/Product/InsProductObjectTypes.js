define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Product/InsProductObjectTypes',
    'l!t!CommonMasterData/Product/FilterInsProductObjectType',
    'l!t!CommonMasterData/Product/InsProductObjectTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsProductObjectType',
        editUrl: '#InsProductObjectTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'description', title: this.resources.description },
				{ field: 'sapId', title: this.resources.sapId },
				{ field: 'isAuNecessary', title: this.resources.isAuNecessary , headerTitle: this.resources.isAuNecessary, checkbox: true},
			];
		}
	});

	return view;
});
