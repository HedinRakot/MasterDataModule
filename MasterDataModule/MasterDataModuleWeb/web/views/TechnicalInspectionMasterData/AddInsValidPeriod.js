define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsValidPeriodRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsValidPeriod',
        actionUrl: '#InsValidPeriods',

		bindings: {
			'#description': 'description',
			'#validityPeriod': 'validityPeriod',
			'#isNextTerminPossible': 'isNextTerminPossible',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'validityPeriod', 'numeric');
			this.disableInput(this, 'isNextTerminPossible');

            return this;
        }
    });

    return view;
});
