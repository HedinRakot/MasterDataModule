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
			'#notificationType': { observe: 'notificationType',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.notificationType
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#isAlertOn': 'isAlertOn',
			'#alertCheckStatus': { observe: 'alertCheckStatus',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.alertCheckStatus
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#alertAttemptCount': 'alertAttemptCount',
			'#message': 'message',
			'#subject': 'subject',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'notificationType', 'select');
			this.disableInput(this, 'isAlertOn');
			this.disableInput(this, 'alertCheckStatus', 'select');
			this.disableInput(this, 'alertAttemptCount', 'numeric');
			this.disableInput(this, 'message');
			this.disableInput(this, 'subject');

            return this;
        }
    });

    return view;
});
