define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/HolidayOrdFederalStates',
    'l!t!DriverLicenceMasterData/FilterHolidayOrdFederalState',
    'l!t!DriverLicenceMasterData/HolidayOrdFederalStateRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'HolidayOrdFederalState',
        editUrl: '#HolidayOrdFederalStates',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'ordFederalStateId', title: this.resources.ordFederalStateId },
			];
		}
	});

	return view;
});
