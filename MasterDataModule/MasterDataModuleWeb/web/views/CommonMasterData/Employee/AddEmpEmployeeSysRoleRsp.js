define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Employee/EmpEmployeeSysRoleRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'EmpEmployeeSysRoleRsp',
        actionUrl: '#EmpEmployeeSysRoleRsps',

		bindings: {
			'#empEmployeeId': 'empEmployeeId',
			'#sysRoleId': 'sysRoleId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'empEmployeeId', 'numeric');
			this.disableInput(this, 'sysRoleId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
