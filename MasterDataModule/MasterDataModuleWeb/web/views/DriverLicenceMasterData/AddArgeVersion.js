define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ArgeVersionRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ArgeVersion',
        actionUrl: '#ArgeVersions',

		bindings: function () {

            var self = this;
            var result = {
			'#programmName': 'programmName',
			'#versionSystem': 'versionSystem',
			'#expirationDate': 'expirationDate',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'programmName');
			this.disableInput(this, 'versionSystem');
			this.disableInput(this, 'expirationDate', 'date');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
