define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/HolidayRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'Holiday',
        actionUrl: '#Holidays',

		bindings: {
			'#name': 'name',
			'#date': 'date',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'date', 'date');

            return this;
        }
    });

    return view;
});
