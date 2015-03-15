define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Product/OrdRecognitionAreaOfWorkRsps',
    'l!t!CommonMasterData/Product/FilterOrdRecognitionAreaOfWorkRsp',
    'l!t!CommonMasterData/Product/OrdRecognitionAreaOfWorkRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrdRecognitionAreaOfWorkRsp',
        editUrl: '#OrdRecognitionAreaOfWorkRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'ordAreaOfWorkId', title: this.resources.ordAreaOfWorkId },
				{ field: 'priority', title: this.resources.priority },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
