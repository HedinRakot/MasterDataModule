define([
'base/base-object-grid-view',
'collections/Settings/WcfInfosWithLastResults',
'l!t!Settings/FilterWcfInfosWithLastResult'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'WcfInfosWithLastResult',
        editUrl: '#WcfInfosWithLastResults',
		
		
		
		

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
