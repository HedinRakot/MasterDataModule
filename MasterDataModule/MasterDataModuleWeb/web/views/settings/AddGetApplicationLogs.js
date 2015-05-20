define([
	'base/base-object-add-view',
    'l!t!Settings/GetApplicationLogsRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'GetApplicationLogs',
        actionUrl: '#GetApplicationLogs',

		bindings: function () {

            var self = this;
            var result = {
			'#logLevel': 'logLevel',
			'#messageDate': 'messageDate',
			'#message': 'message',
			'#fileName': 'fileName',
			'#logTypeInfoId': 'logTypeInfoId',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'logLevel', 'numeric');
			this.disableInput(this, 'messageDate', 'date');
			this.disableInput(this, 'message');
			this.disableInput(this, 'fileName');
			this.disableInput(this, 'logTypeInfoId', 'numeric');

            return this;
        }
    });

    return view;
});
