define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Org/OrgTypes',
    'l!t!CommonMasterData/Org/FilterOrgType',
    'l!t!CommonMasterData/Org/OrgTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrgType',
        editUrl: '#OrgTypes',

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
