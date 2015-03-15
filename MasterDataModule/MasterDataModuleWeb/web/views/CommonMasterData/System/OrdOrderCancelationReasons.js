define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/System/OrdOrderCancelationReasons',
    'l!t!CommonMasterData/System/FilterOrdOrderCancelationReason',
    'l!t!CommonMasterData/System/OrdOrderCancelationReasonRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrdOrderCancelationReason',
        editUrl: '#OrdOrderCancelationReasons',

	    editItemTitle: function () {
	        return this.resources.edit
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
