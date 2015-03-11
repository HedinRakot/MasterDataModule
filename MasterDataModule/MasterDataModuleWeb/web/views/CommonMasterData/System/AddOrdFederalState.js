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
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'federalStateName');
			this.disableInput(this, 'description');
			this.disableInput(this, 'sysCountryId', 'numeric');

            return this;
        }
    });

    return view;
});
