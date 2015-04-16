define([
'base/base-object-grid-view',
'collections/Settings/WinserviceInfosWithLastResults',
'l!t!Settings/FilterWinserviceInfosWithLastResult'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'WinserviceInfosWithLastResult',
        editUrl: '#WinserviceInfosWithLastResults',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },

		columns: function () {
			
			return [
			];
		}

	});

	return view;
});
