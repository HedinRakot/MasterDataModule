define([
	'base/base-object-add-view',
    'l!t!Settings/ApplicationLogsRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ApplicationLogs',
        actionUrl: '#ApplicationLogs',

		bindings: function () {

            var self = this;
            var result = {
			'#logLevel': 'logLevel',
			'#date': 'date',
			'#message': 'message',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#logTypeInfoId': { observe: 'logTypeInfoId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.logTypeInfos
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'logLevel', 'numeric');
			this.disableInput(this, 'date', 'date');
			this.disableInput(this, 'message');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'logTypeInfoId', 'select');

            return this;
        }
    });

    return view;
});
