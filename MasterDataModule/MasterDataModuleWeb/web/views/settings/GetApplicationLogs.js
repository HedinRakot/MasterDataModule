define([
'base/base-object-grid-view',
'collections/Settings/GetApplicationLogs',
'l!t!Settings/FilterGetApplicationLogs'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'GetApplicationLogs',
        editUrl: '#GetApplicationLogs',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'logLevel', title: this.resources.logLevel },
				{ field: 'messageDate', title: this.resources.messageDate , format: '{0:d}'},
				{ field: 'message', title: this.resources.message },
				{ field: 'fileName', title: this.resources.fileName },
				{ field: 'logTypeInfoId', title: this.resources.logTypeInfoId },
			];
		}

	});

	return view;
});
