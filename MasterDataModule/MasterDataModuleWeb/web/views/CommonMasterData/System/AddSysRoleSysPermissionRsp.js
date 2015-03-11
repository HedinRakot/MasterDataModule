define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/SysRoleSysPermissionRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SysRoleSysPermissionRsp',
        actionUrl: '#SysRoleSysPermissionRsps',

		bindings: {
			'#sysRoleId': 'sysRoleId',
			'#sysPermissionId': 'sysPermissionId',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'sysRoleId', 'numeric');
			this.disableInput(this, 'sysPermissionId', 'numeric');

            return this;
        }
    });

    return view;
});
