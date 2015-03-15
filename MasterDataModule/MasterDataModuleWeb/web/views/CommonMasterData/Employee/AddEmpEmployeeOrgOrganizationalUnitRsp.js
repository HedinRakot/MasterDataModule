define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Employee/EmpEmployeeOrgOrganizationalUnitRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'EmpEmployeeOrgOrganizationalUnitRsp',
        actionUrl: '#EmpEmployeeOrgOrganizationalUnitRsps',

		bindings: {
			'#empEmployeeId': 'empEmployeeId',
			'#orgOrganizationalUnitId': 'orgOrganizationalUnitId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'empEmployeeId', 'numeric');
			this.disableInput(this, 'orgOrganizationalUnitId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
