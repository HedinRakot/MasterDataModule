define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/OrdOrderCancelationReasonRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrdOrderCancelationReason',
        actionUrl: '#OrdOrderCancelationReasons',

		bindings: function () {

            var self = this;
            var result = {
			'#cancelationReasonText': 'cancelationReasonText',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'cancelationReasonText');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
