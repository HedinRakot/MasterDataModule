define([
	'base/base-object-grid-view',
'collections/CommonMasterData/System/InsVatTypes',
'l!t!CommonMasterData/System/FilterInsVatType',
'l!t!CommonMasterData/System/InsVatTypeRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsVatType',
        editUrl: '#InsVatTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'description', title: this.resources.description },
				{ field: 'taxCode', title: this.resources.taxCode },
				{ field: 'percent', title: this.resources.percent },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
