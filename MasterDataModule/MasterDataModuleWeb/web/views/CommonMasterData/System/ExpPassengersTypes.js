define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/System/ExpPassengersTypes',
    'l!t!CommonMasterData/System/FilterExpPassengersType',
    'l!t!CommonMasterData/System/ExpPassengersTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExpPassengersType',
        editUrl: '#ExpPassengersTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'text', title: this.resources.text },
				{ field: 'code', title: this.resources.code },
			];
		}
	});

	return view;
});