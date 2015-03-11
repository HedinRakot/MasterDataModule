define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Customer/OrdPartnerRoles',
    'l!t!CommonMasterData/Customer/FilterOrdPartnerRole',
    'l!t!CommonMasterData/Customer/OrdPartnerRoleRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrdPartnerRole',
        editUrl: '#OrdPartnerRoles',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'sapQualifier', title: this.resources.sapQualifier },
			];
		}
	});

	return view;
});
