define([
	'base/base-object-add-view',
    'l!t!Settings/GetJobsStatusRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'GetJobsStatus',
        actionUrl: '#GetJobsStatuses',

		bindings: function () {

            var self = this;
            var result = {
			'#checkStatus': 'checkStatus',
			'#checkDate': 'checkDate',
			'#lastRunTime': 'lastRunTime',
			'#name': 'name',
			'#jobName': 'jobName',
			'#logTypeInfoId': 'logTypeInfoId',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'checkStatus', 'numeric');
			this.disableInput(this, 'checkDate', 'date');
			this.disableInput(this, 'lastRunTime', 'date');
			this.disableInput(this, 'name');
			this.disableInput(this, 'jobName');
			this.disableInput(this, 'logTypeInfoId', 'numeric');

            return this;
        }
    });

    return view;
});
