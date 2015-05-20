define([
'base/base-object-grid-view',
'collections/Settings/GetWinServicesStatuses',
'l!t!Settings/FilterGetWinServicesStatus'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'GetWinServicesStatus',
        editUrl: '#GetWinServicesStatuses',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'checkStatus', title: this.resources.checkStatus },
				{ field: 'checkDate', title: this.resources.checkDate , format: '{0:d}'},
				{ field: 'message', title: this.resources.message },
				{ field: 'attempt', title: this.resources.attempt },
				{ field: 'name', title: this.resources.name },
				{ field: 'machineName', title: this.resources.machineName },
				{ field: 'logTypeInfoId', title: this.resources.logTypeInfoId },
			];
		}

	});

	return view;
});
