define([
'base/base-object-grid-view',
'collections/CommonMasterData/System/SysCountries',
'l!t!CommonMasterData/System/FilterSysCountry'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'SysCountry',
        editUrl: '#SysCountries',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'sapId', title: this.resources.sapId },
				{ field: 'name', title: this.resources.name },
				{ field: 'isEu', title: this.resources.isEu , headerTitle: this.resources.isEu, checkbox: true},
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
