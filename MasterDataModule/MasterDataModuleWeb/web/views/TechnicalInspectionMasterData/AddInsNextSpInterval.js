define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsNextSpIntervalRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsNextSpInterval',
        actionUrl: '#InsNextSpIntervals',

		bindings: {
			'#insProductObjectTypeId': 'insProductObjectTypeId',
			'#insProductObjectClassId': 'insProductObjectClassId',
			'#ageMonthFrom': 'ageMonthFrom',
			'#ageMonthTo': 'ageMonthTo',
			'#spInterval': 'spInterval',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'insProductObjectTypeId', 'numeric');
			this.disableInput(this, 'insProductObjectClassId', 'numeric');
			this.disableInput(this, 'ageMonthFrom', 'numeric');
			this.disableInput(this, 'ageMonthTo', 'numeric');
			this.disableInput(this, 'spInterval', 'numeric');

            return this;
        }
    });

    return view;
});
