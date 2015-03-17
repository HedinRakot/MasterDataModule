define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/MeetingPointOrganizationalUnitRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MeetingPointOrganizationalUnit',
        actionUrl: '#MeetingPointOrganizationalUnits',

		bindings: function () {

            var self = this;
            var result = {
			'#meetingPointId': 'meetingPointId',
			'#orgOrganizationalUnitId': 'orgOrganizationalUnitId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'meetingPointId', 'numeric');
			this.disableInput(this, 'orgOrganizationalUnitId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
