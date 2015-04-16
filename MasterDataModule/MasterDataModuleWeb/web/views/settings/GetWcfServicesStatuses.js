define([
'base/base-object-grid-view',
'collections/Settings/GetWcfServicesStatuses',
'l!t!Settings/FilterGetWcfServicesStatus'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'GetWcfServicesStatus',
        editUrl: '#GetWcfServicesStatuses',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'checkStatus', title: this.resources.checkStatus },
				{ field: 'checkDate', title: this.resources.checkDate , format: '{0:d}'},
				{ field: 'message', title: this.resources.message },
				{ field: 'attempt', title: this.resources.attempt },
				{ field: 'name', title: this.resources.name },
				{ field: 'wsdlPath', title: this.resources.wsdlPath },
			];
		}

	});

	return view;
});
