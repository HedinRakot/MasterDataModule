define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataWindowsServiceInfoRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataWindowsServiceInfo',
        actionUrl: '#MasterDataWindowsServiceInfos',

		bindings: function () {

            var self = this;
            var result = {
			'#name': 'name',
			'#machineName': 'machineName',
			'#serviceName': 'serviceName',
			'#timeoutChecking': 'timeoutChecking',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#logTypeInfoId': { observe: 'logTypeInfoId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.logTypeInfo
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'machineName');
			this.disableInput(this, 'serviceName');
			this.disableInput(this, 'timeoutChecking', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'logTypeInfoId', 'select');

            return this;
        }
    });

    return view;
});
