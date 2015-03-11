define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/System/SysRoles',
    'l!t!CommonMasterData/System/FilterSysRole',
    'l!t!CommonMasterData/System/SysRoleRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'SysRole',
        editUrl: '#SysRoles',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'roleNumber', title: this.resources.roleNumber },
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
			];
		}
	});

	return view;
});
