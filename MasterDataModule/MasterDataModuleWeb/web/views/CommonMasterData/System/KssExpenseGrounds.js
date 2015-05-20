define([
'base/base-object-grid-view',
'collections/CommonMasterData/System/KssExpenseGrounds',
'l!t!CommonMasterData/System/FilterKssExpenseGround'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'KssExpenseGround',
        editUrl: '#KssExpenseGrounds',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'description', title: this.resources.description },
				{ field: 'account', title: this.resources.account },
				{ field: 'insVatTypeId', title: this.resources.insVatTypeId },
				{ field: 'maxAmount', title: this.resources.maxAmount },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
