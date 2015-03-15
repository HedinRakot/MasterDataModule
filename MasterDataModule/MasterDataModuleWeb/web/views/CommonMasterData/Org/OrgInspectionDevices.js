define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Org/OrgInspectionDevices',
    'l!t!CommonMasterData/Org/FilterOrgInspectionDevice',
    'l!t!CommonMasterData/Org/OrgInspectionDeviceRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrgInspectionDevice',
        editUrl: '#OrgInspectionDevices',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'identification', title: this.resources.identification },
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
