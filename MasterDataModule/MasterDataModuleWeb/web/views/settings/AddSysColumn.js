define([
	'base/base-object-add-view',
    'l!t!Settings/SysColumnRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SysColumn',
        actionUrl: '#SysColumns',

		bindings: function () {

            var self = this;
            var result = {
			'#sysTableId': 'sysTableId',
			'#description': 'description',
			'#readOnly': 'readOnly',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'sysTableId', 'numeric');
			this.disableInput(this, 'description');
			this.disableInput(this, 'readOnly');

            return this;
        }
    });

    return view;
});
