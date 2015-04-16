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
			'#masterDataSubscribersId': { observe: 'masterDataSubscribersId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.masterDataSubscribers
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'masterDataNotificationsId', 'numeric');
			this.disableInput(this, 'masterDataSubscribersId', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
