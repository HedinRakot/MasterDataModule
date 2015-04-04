define([
	'base/base-object-add-view',
    'l!t!Settings/ApplicationLogsRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ApplicationLogs',
        actionUrl: '#ApplicationLogs',

		bindings: function () {

            var self = this;
            var result = {
			'#logType': 'logType',
			'#logLevel': 'logLevel',
			'#date': 'date',
			'#message': 'message',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'logType', 'numeric');
			this.disableInput(this, 'logLevel', 'numeric');
			this.disableInput(this, 'date', 'date');
			this.disableInput(this, 'message');

            return this;
        }
    });

    return view;
});
