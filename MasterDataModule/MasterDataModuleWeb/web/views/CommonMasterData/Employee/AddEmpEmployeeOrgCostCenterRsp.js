define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Employee/EmpEmployeeOrgCostCenterRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'EmpEmployeeOrgCostCenterRsp',
        actionUrl: '#EmpEmployeeOrgCostCenterRsps',

		bindings: function () {

            var self = this;
            var result = {
			'#empEmployeeId': 'empEmployeeId',
			'#orgCostCenterId': 'orgCostCenterId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'empEmployeeId', 'numeric');
			this.disableInput(this, 'orgCostCenterId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
