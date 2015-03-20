define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsNextSpIntervalRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsNextSpInterval',
        actionUrl: '#InsNextSpIntervals',

		bindings: function () {

            var self = this;
            var result = {
			'#insProductObjectTypeId': 'insProductObjectTypeId',
			'#insProductObjectClassId': 'insProductObjectClassId',
			'#ageMonthFrom': 'ageMonthFrom',
			'#ageMonthTo': 'ageMonthTo',
			'#spInterval': 'spInterval',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'insProductObjectTypeId', 'numeric');
			this.disableInput(this, 'insProductObjectClassId', 'numeric');
			this.disableInput(this, 'ageMonthFrom', 'numeric');
			this.disableInput(this, 'ageMonthTo', 'numeric');
			this.disableInput(this, 'spInterval', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
