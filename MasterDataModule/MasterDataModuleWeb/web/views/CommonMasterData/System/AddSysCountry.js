define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/SysCountryRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SysCountry',
        actionUrl: '#SysCountries',

		bindings: {
			'#sapId': 'sapId',
			'#name': 'name',
			'#isEu': 'isEu',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'sapId');
			this.disableInput(this, 'name');
			this.disableInput(this, 'isEu');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
