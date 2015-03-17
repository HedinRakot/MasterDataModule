define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/HolidayOrdFederalStateRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'HolidayOrdFederalState',
        actionUrl: '#HolidayOrdFederalStates',

		bindings: function () {

            var self = this;
            var result = {
			'#holidayId': 'holidayId',
			'#ordFederalStateId': 'ordFederalStateId',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'holidayId', 'numeric');
			this.disableInput(this, 'ordFederalStateId', 'numeric');

            return this;
        }
    });

    return view;
});
