define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Employee/EmpEmployeeTopEmployeeRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'EmpEmployeeTopEmployeeRsp',
        actionUrl: '#EmpEmployeeTopEmployeeRsps',

		bindings: function () {

            var self = this;
            var result = {
			'#empEmployeeId': 'empEmployeeId',
			'#topEmployeeId': 'topEmployeeId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'empEmployeeId', 'numeric');
			this.disableInput(this, 'topEmployeeId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
