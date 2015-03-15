define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/MeetingPointOrganizationalUnits',
    'l!t!DriverLicenceMasterData/FilterMeetingPointOrganizationalUnit',
    'l!t!DriverLicenceMasterData/MeetingPointOrganizationalUnitRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MeetingPointOrganizationalUnit',
        editUrl: '#MeetingPointOrganizationalUnits',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'orgOrganizationalUnitId', title: this.resources.orgOrganizationalUnitId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
