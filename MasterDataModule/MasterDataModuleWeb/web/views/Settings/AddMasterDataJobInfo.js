define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataJobInfoRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataJobInfo',
        actionUrl: '#MasterDataJobInfos',

		bindings: function () {

            var self = this;
            var result = {
			'#connectionString': 'connectionString',
			'#tableName': 'tableName',
			'#timeoutChecking': 'timeoutChecking',
			'#name': 'name',
			'#jobName': 'jobName',
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
			this.disableInput(this, 'connectionString');
			this.disableInput(this, 'tableName');
			this.disableInput(this, 'timeoutChecking', 'numeric');
			this.disableInput(this, 'name');
			this.disableInput(this, 'jobName');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'logTypeInfoId', 'select');

            return this;
        }
    });

    return view;
});
