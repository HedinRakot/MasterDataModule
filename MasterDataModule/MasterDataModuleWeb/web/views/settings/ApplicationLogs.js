define([
'base/base-object-grid-view',
'collections/Settings/ApplicationLogs',
'l!t!Settings/FilterApplicationLogs'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'ApplicationLogs',
        editUrl: '#ApplicationLogs',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'logLevel', title: this.resources.logLevel },
				{ field: 'date', title: this.resources.date , format: '{0:d}'},
				{ field: 'message', title: this.resources.message },
				{ field: 'logTypeInfoId', title: this.resources.logTypeInfoId , collection: this.options.logTypeInfos, defaultText: this.resources.pleaseSelect},
			];
		}

	});

	return view;
});
