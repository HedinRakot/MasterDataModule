define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/SysRoleSysPermissionRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SysRoleSysPermissionRsp',
        actionUrl: '#SysRoleSysPermissionRsps',

		bindings: function () {

            var self = this;
            var result = {
			'#sysRoleId': 'sysRoleId',
			'#sysPermissionId': 'sysPermissionId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'sysRoleId', 'numeric');
			this.disableInput(this, 'sysPermissionId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
