define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/OrdFederalStateRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrdFederalState',
        actionUrl: '#OrdFederalStates',

		bindings: {
			'#federalStateName': 'federalStateName',
			'#description': 'description',
			'#sysCountryId': 'sysCountryId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'federalStateName');
			this.disableInput(this, 'description');
			this.disableInput(this, 'sysCountryId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
