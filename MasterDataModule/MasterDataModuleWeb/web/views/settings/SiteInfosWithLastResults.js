define([
'base/base-object-grid-view',
'collections/Settings/SiteInfosWithLastResults',
'l!t!Settings/FilterSiteInfosWithLastResult'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'SiteInfosWithLastResult',
        editUrl: '#SiteInfosWithLastResults',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
			];
		}

	});

	return view;
});
