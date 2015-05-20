define([
	'base/base-object-add-view',
    'l!t!Settings/GetSitesStatusRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'GetSitesStatus',
        actionUrl: '#GetSitesStatuses',

		bindings: function () {

            var self = this;
            var result = {
			'#checkStatus': 'checkStatus',
			'#checkDate': 'checkDate',
			'#message': 'message',
			'#attempt': 'attempt',
			'#name': 'name',
			'#sitePath': 'sitePath',
			'#logTypeInfoId': 'logTypeInfoId',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'checkStatus', 'numeric');
			this.disableInput(this, 'checkDate', 'date');
			this.disableInput(this, 'message');
			this.disableInput(this, 'attempt', 'numeric');
			this.disableInput(this, 'name');
			this.disableInput(this, 'sitePath');
			this.disableInput(this, 'logTypeInfoId', 'numeric');

            return this;
        }
    });

    return view;
});
