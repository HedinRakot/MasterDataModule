define([
	'base/base-object-grid-view',
'collections/CommonMasterData/Customer/OrdCustomerInfos',
'l!t!CommonMasterData/Customer/FilterOrdCustomerInfo',
'l!t!CommonMasterData/Customer/OrdCustomerInfoRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrdCustomerInfo',
        editUrl: '#OrdCustomerInfos',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'textValue', title: this.resources.textValue },
				{ field: 'numberValue', title: this.resources.numberValue },
				{ field: 'infoType', title: this.resources.infoType },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
