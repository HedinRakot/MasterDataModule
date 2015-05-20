define([
'base/base-object-grid-view',
'collections/CommonMasterData/System/OrdOrderCancelationReasons',
'l!t!CommonMasterData/System/FilterOrdOrderCancelationReason'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'OrdOrderCancelationReason',
        editUrl: '#OrdOrderCancelationReasons',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'cancelationReasonText', title: this.resources.cancelationReasonText },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
