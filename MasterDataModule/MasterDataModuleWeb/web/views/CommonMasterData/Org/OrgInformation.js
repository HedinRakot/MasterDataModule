define([
	'base/base-object-grid-view',
'collections/CommonMasterData/Org/OrgInformation',
'l!t!CommonMasterData/Org/FilterOrgInformation',
'l!t!CommonMasterData/Org/OrgInformationRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrgInformation',
        editUrl: '#OrgInformation',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'name', title: this.resources.name },
				{ field: 'value', title: this.resources.value },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
