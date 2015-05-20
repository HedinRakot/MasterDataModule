define([
'base/base-object-grid-view',
'collections/CommonMasterData/System/SysLocations',
'l!t!CommonMasterData/System/FilterSysLocation'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'SysLocation',
        editUrl: '#SysLocations',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'locationCode', title: this.resources.locationCode },
				{ field: 'locationName', title: this.resources.locationName },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
