define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/DriverSchoolRelationships'
], function (BaseView , TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'DriverSchool',
        actionUrl: '#DriverSchools',

		bindings: function () {

            var self = this;
            var result = {
			'#driverSchoolNumber': 'driverSchoolNumber',
			'#ordCustomerId': 'ordCustomerId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'driverSchoolNumber');
			this.disableInput(this, 'ordCustomerId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
		,events: {
		}
    });

    return view;
});
