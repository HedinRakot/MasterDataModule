define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Customer/InsTaxClasses',
    'l!t!CommonMasterData/Customer/FilterInsTaxClass',
    'l!t!CommonMasterData/Customer/InsTaxClassRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsTaxClass',
        editUrl: '#InsTaxClasses',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'taxClass', title: this.resources.taxClass },
			];
		}
	});

	return view;
});
