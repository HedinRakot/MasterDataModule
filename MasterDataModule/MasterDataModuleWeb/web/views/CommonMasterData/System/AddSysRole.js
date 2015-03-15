define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/SysRoleRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SysRole',
        actionUrl: '#SysRoles',

		bindings: {
			'#roleNumber': 'roleNumber',
			'#name': 'name',
			'#description': 'description',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'roleNumber', 'numeric');
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
