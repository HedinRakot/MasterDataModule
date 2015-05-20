define([
'base/base-object-grid-view',
'collections/TechnicalInspectionMasterData/InsPfpPositions',
'l!t!TechnicalInspectionMasterData/FilterInsPfpPosition'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'InsPfpPosition',
        editUrl: '#InsPfpPositions',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'text', title: this.resources.text },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
