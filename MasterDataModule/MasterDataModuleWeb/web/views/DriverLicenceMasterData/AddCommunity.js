define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/CommunityRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'Community',
        actionUrl: '#Communities',

		bindings: {
			'#driverSchoolId': 'driverSchoolId',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'driverSchoolId', 'numeric');

            return this;
        }
    });

    return view;
});
