define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Org/OrgCostCenterResponsibleEmployeeRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrgCostCenterResponsibleEmployeeRsp',
        actionUrl: '#OrgCostCenterResponsibleEmployeeRsps',

		bindings: {
			'#orgCostCenterId': 'orgCostCenterId',
			'#empEmployeeId': 'empEmployeeId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'orgCostCenterId', 'numeric');
			this.disableInput(this, 'empEmployeeId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
