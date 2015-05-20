define([
'base/base-object-grid-view',
'collections/CommonMasterData/Product/InsTaxCodes',
'l!t!CommonMasterData/Product/FilterInsTaxCode'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'InsTaxCode',
        editUrl: '#InsTaxCodes',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'taxCode', title: this.resources.taxCode },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
