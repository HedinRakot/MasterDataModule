define([
	'base/base-object-grid-view',
'collections/CommonMasterData/Product/OrdRecognitions',
'l!t!CommonMasterData/Product/FilterOrdRecognition',
'l!t!CommonMasterData/Product/OrdRecognitionRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrdRecognition',
        editUrl: '#OrdRecognitions',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'ordRecognitionTypeId', title: this.resources.ordRecognitionTypeId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
				{ field: 'orgAccountingAreaId', title: this.resources.orgAccountingAreaId },
			];
		}

	});

	return view;
});
