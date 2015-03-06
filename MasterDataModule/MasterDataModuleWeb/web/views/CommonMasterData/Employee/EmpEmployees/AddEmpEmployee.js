define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Employee/EmpEmployees/EmpEmployeesRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'empEmployee',
        actionUrl: '#EmpEmployees',

        bindings: {
            '#name': 'name',
            '#lastName': 'lastName',
            '#fromDate': 'fromDate',
            '#toDate': 'toDate',
            '#middleName': 'middleName',
            '#personalNumber': 'personalNumber',
        },

        render: function () {

            view.__super__.render.apply(this, arguments);
            
            //TODO foreach model field
            this.disableInput(this, 'name');
            this.disableInput(this, 'lastName');
            this.disableInput(this, 'fromDate', 'date');
            this.disableInput(this, 'toDate', 'date');
            this.disableInput(this, 'middleName');
            this.disableInput(this, 'personalNumber');

            //todo disable select button

            return this;
        }
    });

    return view;
});