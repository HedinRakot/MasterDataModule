define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataRolePermissionRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataRolePermissionRsp',
        actionUrl: '#MasterDataRolePermissionRsps',

		bindings: function () {

            var self = this;
            var result = {
			'#masterDataRoleId': 'masterDataRoleId',
			'#masterDataPermissionId': 'masterDataPermissionId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'masterDataRoleId', 'numeric');
			this.disableInput(this, 'masterDataPermissionId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
