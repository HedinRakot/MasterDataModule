define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Employee/EmpEmployeeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'EmpEmployee',
        actionUrl: '#EmpEmployees',

		bindings: function () {

            var self = this;
            var result = {
			'#personalNumber': 'personalNumber',
			'#domain': 'domain',
			'#userName': 'userName',
			'#windowsUserName': 'windowsUserName',
			'#isSsoAllowed': 'isSsoAllowed',
			'#isEmergencyLoginAllowed': 'isEmergencyLoginAllowed',
			'#name': 'name',
			'#middleName': 'middleName',
			'#lastName': 'lastName',
			'#comment': 'comment',
			'#sexType': 'sexType',
			'#title': 'title',
			'#birthdate': 'birthdate',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'personalNumber');
			this.disableInput(this, 'domain');
			this.disableInput(this, 'userName');
			this.disableInput(this, 'windowsUserName');
			this.disableInput(this, 'isSsoAllowed');
			this.disableInput(this, 'isEmergencyLoginAllowed');
			this.disableInput(this, 'name');
			this.disableInput(this, 'middleName');
			this.disableInput(this, 'lastName');
			this.disableInput(this, 'comment');
			this.disableInput(this, 'sexType', 'numeric');
			this.disableInput(this, 'title');
			this.disableInput(this, 'birthdate', 'date');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
