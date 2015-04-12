define([
'base/base-object-grid-view',
'collections/Settings/MasterDataSubscribers',
'l!t!Settings/FilterMasterDataSubscribers'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'MasterDataSubscribers',
        editUrl: '#MasterDataSubscribers',
		addNewModelInline: true,
		showAddButton: true,
		showEditButton: true,
		showDeleteButton: true,

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
