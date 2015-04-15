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
			'#monitorableInfoType': { observe: 'monitorableInfoType',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.checkModuleType
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#monitorableInfoId': 'monitorableInfoId',
			'#masterDataNotificationsId': { observe: 'masterDataNotificationsId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.masterDataNotifications
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'masterDataNotificationsId', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
