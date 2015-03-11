define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/MeetingPoints',
    'l!t!DriverLicenceMasterData/FilterMeetingPoint',
    'l!t!DriverLicenceMasterData/MeetingPointRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MeetingPoint',
        editUrl: '#MeetingPoints',

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
