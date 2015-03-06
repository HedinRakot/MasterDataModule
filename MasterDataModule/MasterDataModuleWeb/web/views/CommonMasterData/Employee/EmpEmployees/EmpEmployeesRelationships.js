define([
	'base/base-object-tab-view',
    'kendo/kendo.tabstrip'
], function (BaseView) {
    'use strict';

    var view = BaseView.extend({

        tabs: function () {
            
            var result = [
                {
                    view: 'l!t!CommonMasterData/Employee/EmpEmployeeSysRoleRsps/EmpEmployeeSysRoleRsps',
                    selector: '.empEmployeeSysRoleRsps'
                },
            ];
            
            return result;
        }
    });

    return view;
});