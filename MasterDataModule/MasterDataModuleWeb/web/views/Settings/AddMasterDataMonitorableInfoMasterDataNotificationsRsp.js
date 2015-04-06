define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataMonitorableInfoMasterDataNotificationsRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataMonitorableInfoMasterDataNotificationsRsp',
        actionUrl: '#MasterDataMonitorableInfoMasterDataNotificationsRsps',

		bindings: function () {

            var self = this;
            var result = {
			'#monitorableInfoType': 'monitorableInfoType',
			'#monitorableInfoId': 'monitorableInfoId',
			'#masterDataNotificationsId': 'masterDataNotificationsId',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'monitorableInfoType', 'numeric');
			this.disableInput(this, 'monitorableInfoId', 'numeric');
			this.disableInput(this, 'masterDataNotificationsId', 'numeric');

            return this;
        }
    });

    return view;
});
