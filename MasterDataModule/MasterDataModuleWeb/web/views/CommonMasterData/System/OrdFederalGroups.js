define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/System/OrdFederalGroups',
    'l!t!CommonMasterData/System/FilterOrdFederalGroup',
    'l!t!CommonMasterData/System/OrdFederalGroupRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrdFederalGroup',
        editUrl: '#OrdFederalGroups',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
			];
		}
	});

	return view;
});
