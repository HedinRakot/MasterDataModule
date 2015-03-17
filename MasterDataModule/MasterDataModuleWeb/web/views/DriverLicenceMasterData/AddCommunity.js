define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/CommunityRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'Community',
        actionUrl: '#Communities',

		bindings: function () {

            var self = this;
            var result = {
			'#driverSchoolId': 'driverSchoolId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'driverSchoolId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
