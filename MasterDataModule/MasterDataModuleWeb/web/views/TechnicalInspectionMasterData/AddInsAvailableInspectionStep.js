define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsAvailableInspectionStepRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsAvailableInspectionStep',
        actionUrl: '#InsAvailableInspectionSteps',

		bindings: {
			'#insInspectionStepId': 'insInspectionStepId',
			'#isMandatory': 'isMandatory',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'insInspectionStepId', 'numeric');
			this.disableInput(this, 'isMandatory');

            return this;
        }
    });

    return view;
});