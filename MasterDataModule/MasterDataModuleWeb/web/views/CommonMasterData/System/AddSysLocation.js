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
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'locationCode');
			this.disableInput(this, 'locationName');
			this.disableInput(this, 'sysCountryId', 'numeric');
			this.disableInput(this, 'ordFederalStateId', 'numeric');

            return this;
        }
    });

    return view;
});
