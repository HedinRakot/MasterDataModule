define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/SysLocationRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SysLocation',
        actionUrl: '#SysLocations',

		bindings: {
			'#locationCode': 'locationCode',
			'#locationName': 'locationName',
			'#sysCountryId': 'sysCountryId',
			'#ordFederalStateId': 'ordFederalStateId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'locationCode');
			this.disableInput(this, 'locationName');
			this.disableInput(this, 'sysCountryId', 'numeric');
			this.disableInput(this, 'ordFederalStateId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
