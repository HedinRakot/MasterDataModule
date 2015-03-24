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
			'#masterDataRoleId': { observe: 'masterDataRoleId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.role
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#masterDataPermissionId': { observe: 'masterDataPermissionId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.permission
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'masterDataRoleId', 'select');
			this.disableInput(this, 'masterDataPermissionId', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
