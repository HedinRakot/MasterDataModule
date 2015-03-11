define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/System/SysLocations',
    'l!t!CommonMasterData/System/FilterSysLocation',
    'l!t!CommonMasterData/System/SysLocationRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'SysLocation',
        editUrl: '#SysLocations',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'locationCode', title: this.resources.locationCode },
				{ field: 'locationName', title: this.resources.locationName },
				{ field: 'sysCountryId', title: this.resources.sysCountryId },
				{ field: 'ordFederalStateId', title: this.resources.ordFederalStateId },
			];
		}
	});

	return view;
});
