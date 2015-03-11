define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/OrdOrderCancelationReasonRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrdOrderCancelationReason',
        actionUrl: '#OrdOrderCancelationReasons',

		bindings: {
			'#cancelationReasonText': 'cancelationReasonText',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'cancelationReasonText');

            return this;
        }
    });

    return view;
});
