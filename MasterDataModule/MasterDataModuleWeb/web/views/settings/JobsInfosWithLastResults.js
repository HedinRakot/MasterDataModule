define([
'base/base-object-grid-view',
'collections/Settings/JobsInfosWithLastResults',
'l!t!Settings/FilterJobsInfosWithLastResult'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'JobsInfosWithLastResult',
        editUrl: '#JobsInfosWithLastResults',
		
		
		
		

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
