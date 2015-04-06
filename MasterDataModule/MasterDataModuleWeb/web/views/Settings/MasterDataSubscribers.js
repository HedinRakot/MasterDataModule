define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataSubscribers',
'l!t!Settings/FilterMasterDataSubscribers',
'l!t!Settings/MasterDataSubscribersRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MasterDataSubscribers',
        editUrl: '#MasterDataSubscribers',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'email', title: this.resources.email },
			];
		}

	});

	return view;
});
