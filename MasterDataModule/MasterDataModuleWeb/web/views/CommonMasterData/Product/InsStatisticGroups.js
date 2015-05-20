define([
'base/base-object-grid-view',
'collections/CommonMasterData/Product/InsStatisticGroups',
'l!t!CommonMasterData/Product/FilterInsStatisticGroup'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'InsStatisticGroup',
        editUrl: '#InsStatisticGroups',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'description', title: this.resources.description },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
