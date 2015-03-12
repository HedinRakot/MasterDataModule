define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Product/OrdRecognitionTypes',
    'l!t!CommonMasterData/Product/FilterOrdRecognitionType',
    'l!t!CommonMasterData/Product/OrdRecognitionTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrdRecognitionType',
        editUrl: '#OrdRecognitionTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
			];
		}
	});

	return view;
});