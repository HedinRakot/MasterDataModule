define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataWindowsServiceCheckResultsRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataWindowsServiceCheckResults',
        actionUrl: '#MasterDataWindowsServiceCheckResults',

		bindings: function () {

            var self = this;
            var result = {
			'#checkStatus': 'checkStatus',
			'#checkDate': 'checkDate',
			'#message': 'message',
			'#attempt': 'attempt',
			'#masterDataWindowsServiceInfoId': 'masterDataWindowsServiceInfoId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
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
			this.disableInput(this, 'masterDataWindowsServiceInfoId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
