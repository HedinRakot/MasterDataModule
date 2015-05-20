define([
'base/base-object-grid-view',
'collections/Settings/GetSitesStatuses',
'l!t!Settings/FilterGetSitesStatus'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'GetSitesStatus',
        editUrl: '#GetSitesStatuses',
		
		
		
		

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
				{ field: 'sitePath', title: this.resources.sitePath },
				{ field: 'logTypeInfoId', title: this.resources.logTypeInfoId },
			];
		}

	});

	return view;
});
