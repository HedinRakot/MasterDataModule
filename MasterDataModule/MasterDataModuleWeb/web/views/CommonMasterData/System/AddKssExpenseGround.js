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
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'account');
			this.disableInput(this, 'insVatTypeId', 'numeric');
			this.disableInput(this, 'maxAmount', 'numeric');

            return this;
        }
    });

    return view;
});
