define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/KssExpenseGroundRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'KssExpenseGround',
        actionUrl: '#KssExpenseGrounds',

		bindings: {
			'#description': 'description',
			'#account': 'account',
			'#insVatTypeId': 'insVatTypeId',
			'#maxAmount': 'maxAmount',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'account');
			this.disableInput(this, 'insVatTypeId', 'numeric');
			this.disableInput(this, 'maxAmount', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
