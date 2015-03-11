define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/Communities',
    'l!t!DriverLicenceMasterData/FilterCommunity',
    'l!t!DriverLicenceMasterData/CommunityRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'Community',
        editUrl: '#Communities',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'driverSchoolId', title: this.resources.driverSchoolId },
			];
		}
	});

	return view;
});
