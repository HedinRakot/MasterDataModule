define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataJobCheckResultsRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataJobCheckResults',
        actionUrl: '#MasterDataJobCheckResults',

		bindings: function () {

            var self = this;
            var result = {
			'#lastRunTime': 'lastRunTime',
			'#checkDate': 'checkDate',
			'#checkStatus': 'checkStatus',
			'#masterDataJobInfoId': 'masterDataJobInfoId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'lastRunTime', 'date');
			this.disableInput(this, 'checkDate', 'date');
			this.disableInput(this, 'checkStatus', 'numeric');
			this.disableInput(this, 'masterDataJobInfoId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
