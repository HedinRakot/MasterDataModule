define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Org/OrgAccountTypes',
    'l!t!CommonMasterData/Org/FilterOrgAccountType',
    'l!t!CommonMasterData/Org/OrgAccountTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrgAccountType',
        editUrl: '#OrgAccountTypes',

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
