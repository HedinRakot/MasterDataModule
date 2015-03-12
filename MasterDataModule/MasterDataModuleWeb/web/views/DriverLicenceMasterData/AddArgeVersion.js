define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ArgeVersionRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ArgeVersion',
        actionUrl: '#ArgeVersions',

		bindings: {
			'#programmName': 'programmName',
			'#versionSystem': 'versionSystem',
			'#expirationDate': 'expirationDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'programmName');
			this.disableInput(this, 'versionSystem');
			this.disableInput(this, 'expirationDate', 'date');

            return this;
        }
    });

    return view;
});