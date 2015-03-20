define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsAvailableInspectionStepRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsAvailableInspectionStep',
        actionUrl: '#InsAvailableInspectionSteps',

		bindings: function () {

            var self = this;
            var result = {
			'#insInspectionStepId': 'insInspectionStepId',
			'#isMandatory': 'isMandatory',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'insInspectionStepId', 'numeric');
			this.disableInput(this, 'isMandatory');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
