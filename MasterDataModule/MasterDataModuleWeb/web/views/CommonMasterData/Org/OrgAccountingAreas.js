define([
'base/base-object-grid-view',
'collections/CommonMasterData/Org/OrgAccountingAreas',
'l!t!CommonMasterData/Org/FilterOrgAccountingArea'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'OrgAccountingArea',
        editUrl: '#OrgAccountingAreas',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'accountingArea', title: this.resources.accountingArea },
				{ field: 'maxOrderSum', title: this.resources.maxOrderSum },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
