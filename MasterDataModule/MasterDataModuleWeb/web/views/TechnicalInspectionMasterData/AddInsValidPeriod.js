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
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'validityPeriod', 'numeric');
			this.disableInput(this, 'isNextTerminPossible');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
