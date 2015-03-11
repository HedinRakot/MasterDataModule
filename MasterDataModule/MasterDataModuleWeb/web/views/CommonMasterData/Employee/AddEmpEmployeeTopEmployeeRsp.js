define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Employee/EmpEmployeeTopEmployeeRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'EmpEmployeeTopEmployeeRsp',
        actionUrl: '#EmpEmployeeTopEmployeeRsps',

		bindings: {
			'#empEmployeeId': 'empEmployeeId',
			'#topEmployeeId': 'topEmployeeId',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'empEmployeeId', 'numeric');
			this.disableInput(this, 'topEmployeeId', 'numeric');

            return this;
        }
    });

    return view;
});
