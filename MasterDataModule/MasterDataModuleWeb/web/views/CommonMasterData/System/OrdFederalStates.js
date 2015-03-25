define([
	'base/base-object-grid-view',
'collections/CommonMasterData/System/OrdFederalStates',
'l!t!CommonMasterData/System/FilterOrdFederalState',
'l!t!CommonMasterData/System/OrdFederalStateRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrdFederalState',
        editUrl: '#OrdFederalStates',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'federalStateName', title: this.resources.federalStateName },
				{ field: 'description', title: this.resources.description },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
