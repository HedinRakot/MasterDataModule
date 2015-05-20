define([
'base/base-object-grid-view',
'collections/CommonMasterData/System/ExpPassengersTypes',
'l!t!CommonMasterData/System/FilterExpPassengersType'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'ExpPassengersType',
        editUrl: '#ExpPassengersTypes',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'text', title: this.resources.text },
				{ field: 'code', title: this.resources.code },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
