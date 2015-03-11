define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Org/OrgBankInformationRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrgBankInformation',
        actionUrl: '#OrgBankInformation',

		bindings: {
			'#bankName': 'bankName',
			'#bankCode': 'bankCode',
			'#bankAccount': 'bankAccount',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'bankName');
			this.disableInput(this, 'bankCode');
			this.disableInput(this, 'bankAccount');

            return this;
        }
    });

    return view;
});
