define([
	'base/base-object-grid-view',
'collections/CommonMasterData/Customer/OrdContactPersonFunctions',
'l!t!CommonMasterData/Customer/FilterOrdContactPersonFunction',
'l!t!CommonMasterData/Customer/OrdContactPersonFunctionRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrdContactPersonFunction',
        editUrl: '#OrdContactPersonFunctions',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'sapId', title: this.resources.sapId },
				{ field: 'description', title: this.resources.description },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
