define([
	'base/base-object-add-view',
    'l!t!Settings/UserRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'User',
        actionUrl: '#Users',

		bindings: function () {

            var self = this;
            var result = {
			'#masterDataRoleId': { observe: 'masterDataRoleId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.role
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#login': 'login',
			'#name': 'name',
			'#password': 'password',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'masterDataRoleId', 'select');
			this.disableInput(this, 'login');
			this.disableInput(this, 'name');
			this.disableInput(this, 'password');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
