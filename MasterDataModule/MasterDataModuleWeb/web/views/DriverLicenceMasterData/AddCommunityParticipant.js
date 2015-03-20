define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/CommunityParticipantRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'CommunityParticipant',
        actionUrl: '#CommunityParticipants',

		bindings: function () {

            var self = this;
            var result = {
			'#driverSchoolIdParticipant': 'driverSchoolIdParticipant',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#driverSchoolIdLead': 'driverSchoolIdLead',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'driverSchoolIdParticipant', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'driverSchoolIdLead', 'numeric');

            return this;
        }
    });

    return view;
});
