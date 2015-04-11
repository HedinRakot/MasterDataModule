define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataNotificationsRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataNotifications',
        actionUrl: '#MasterDataNotifications',

		bindings: function () {

            var self = this;
            var result = {
			'#notificationType': 'notificationType',
			'#isAlertOn': 'isAlertOn',
			'#alertCheckStatus': 'alertCheckStatus',
			'#alertAttemptCount': 'alertAttemptCount',
			'#message': 'message',
			'#subject': 'subject',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'notificationType', 'numeric');
			this.disableInput(this, 'isAlertOn');
			this.disableInput(this, 'alertCheckStatus', 'numeric');
			this.disableInput(this, 'alertAttemptCount', 'numeric');
			this.disableInput(this, 'message');
			this.disableInput(this, 'subject');

            return this;
        }
    });

    return view;
});
