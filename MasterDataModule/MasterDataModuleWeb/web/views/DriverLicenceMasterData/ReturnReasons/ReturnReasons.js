define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ReturnReasons',
    'l!t!DriverLicenceMasterData/ReturnReasons/FilterReturnReasons',
    'l!t!DriverLicenceMasterData/ReturnReasons/ReturnReasonsRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
	    detailView: DetailView,
        filterView: FilterView,
        tableName: 'returnReason',
        editUrl: '#ReturnReasons',

        editItemTitle: function () {
            return this.resources.edit;
        },
        
		columns: function () {
		    return [
		        { field: 'name', title: this.resources.name, width: '130px' },
		        { field: 'description', title: this.resources.description },
		        { field: 'text1', title: this.resources.text1 },
		        { field: 'text2', title: this.resources.text2 },
		        { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' }
		    ];
		}
	});

	return view;
});