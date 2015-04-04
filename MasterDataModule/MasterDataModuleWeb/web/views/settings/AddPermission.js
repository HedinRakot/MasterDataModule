define([
	'base/base-object-add-view',
    'l!t!Settings/PermissionRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'Permission',
        actionUrl: '#Permissions',

		bindings: function () {

            var self = this;
            var result = {
			'#systemName': 'systemName',
			'#name': 'name',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'systemName');
			this.disableInput(this, 'name');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
