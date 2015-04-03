define([
	'base/base-object-grid-view',
'collections/CommonMasterData/Org/OrgOrganizationalUnits',
'l!t!CommonMasterData/Org/FilterOrgOrganizationalUnit',
'l!t!CommonMasterData/Org/OrgOrganizationalUnitRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrgOrganizationalUnit',
        editUrl: '#OrgOrganizationalUnits',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'orgNumber', title: this.resources.orgNumber },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
