define([
'base/base-object-grid-view',
'collections/TechnicalInspectionMasterData/InsValidPeriods',
'l!t!TechnicalInspectionMasterData/FilterInsValidPeriod'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'InsValidPeriod',
        editUrl: '#InsValidPeriods',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'description', title: this.resources.description },
				{ field: 'validityPeriod', title: this.resources.validityPeriod },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
