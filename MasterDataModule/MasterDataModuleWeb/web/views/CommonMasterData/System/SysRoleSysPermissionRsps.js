define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/System/SysRoleSysPermissionRsps',
    'l!t!CommonMasterData/System/FilterSysRoleSysPermissionRsp',
    'l!t!CommonMasterData/System/SysRoleSysPermissionRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'SysRoleSysPermissionRsp',
        editUrl: '#SysRoleSysPermissionRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'sysRoleId', title: this.resources.sysRoleId },
				{ field: 'sysPermissionId', title: this.resources.sysPermissionId },
			];
		}
	});

	return view;
});
