define([
	'base/base-object-grid-view',
'collections/Settings/Permissions',
'l!t!Settings/FilterPermission',
'l!t!Settings/PermissionRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'Permission',
        editUrl: '#Permissions',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'systemName', title: this.resources.systemName },
				{ field: 'name', title: this.resources.name },
			];
		}
	});

	return view;
});
