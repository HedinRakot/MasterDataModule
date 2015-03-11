define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Product/InsCoreDataProductGroups',
    'l!t!CommonMasterData/Product/FilterInsCoreDataProductGroup',
    'l!t!CommonMasterData/Product/InsCoreDataProductGroupRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsCoreDataProductGroup',
        editUrl: '#InsCoreDataProductGroups',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
				{ field: 'defaultDuration', title: this.resources.defaultDuration },
			];
		}
	});

	return view;
});
