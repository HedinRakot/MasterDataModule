define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataNotificationsMasterDataSubscribersRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataNotificationsMasterDataSubscribersRsp',
        actionUrl: '#MasterDataNotificationsMasterDataSubscribersRsps',

		bindings: function () {

            var self = this;
            var result = {
			'#masterDataNotificationsId': 'masterDataNotificationsId',
			'#masterDataSubscribersId': 'masterDataSubscribersId',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'masterDataNotificationsId', 'numeric');
			this.disableInput(this, 'masterDataSubscribersId', 'numeric');

            return this;
        }
    });

    return view;
});
