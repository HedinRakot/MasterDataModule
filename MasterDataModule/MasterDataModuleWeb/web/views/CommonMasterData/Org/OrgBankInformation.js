define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Org/OrgBankInformation',
    'l!t!CommonMasterData/Org/FilterOrgBankInformation',
    'l!t!CommonMasterData/Org/OrgBankInformationRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrgBankInformation',
        editUrl: '#OrgBankInformation',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'bankName', title: this.resources.bankName },
				{ field: 'bankCode', title: this.resources.bankCode },
				{ field: 'bankAccount', title: this.resources.bankAccount },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
