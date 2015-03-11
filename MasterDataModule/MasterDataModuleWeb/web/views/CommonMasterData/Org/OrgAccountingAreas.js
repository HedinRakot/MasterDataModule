define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Org/OrgAccountingAreas',
    'l!t!CommonMasterData/Org/FilterOrgAccountingArea',
    'l!t!CommonMasterData/Org/OrgAccountingAreaRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrgAccountingArea',
        editUrl: '#OrgAccountingAreas',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'accountingArea', title: this.resources.accountingArea },
				{ field: 'maxOrderSum', title: this.resources.maxOrderSum },
			];
		}
	});

	return view;
});
