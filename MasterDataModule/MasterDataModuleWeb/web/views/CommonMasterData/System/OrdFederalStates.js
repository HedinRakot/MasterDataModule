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
				{ field: 'sysCountryId', title: this.resources.sysCountryId },
			];
		}
	});

	return view;
});
