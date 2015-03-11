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
				{ field: 'debitorCustomerNumber', title: this.resources.debitorCustomerNumber },
				{ field: 'identification', title: this.resources.identification },
				{ field: 'newIdentification', title: this.resources.newIdentification },
				{ field: 'oldIdentification', title: this.resources.oldIdentification },
				{ field: 'type', title: this.resources.type },
				{ field: 'serialNumber', title: this.resources.serialNumber },
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
				{ field: 'lastInspectionDate', title: this.resources.lastInspectionDate , format: '{0:d}'},
				{ field: 'lastInspectionResult', title: this.resources.lastInspectionResult },
				{ field: 'inspectionDate', title: this.resources.inspectionDate , format: '{0:d}'},
				{ field: 'inspectionInterval', title: this.resources.inspectionInterval },
			];
		}
	});

	return view;
});
