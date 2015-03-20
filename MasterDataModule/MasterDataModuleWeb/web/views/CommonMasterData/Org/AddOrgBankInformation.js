define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Org/OrgBankInformationRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrgBankInformation',
        actionUrl: '#OrgBankInformation',

		bindings: function () {

            var self = this;
            var result = {
			'#bankName': 'bankName',
			'#bankCode': 'bankCode',
			'#bankAccount': 'bankAccount',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'bankName');
			this.disableInput(this, 'bankCode');
			this.disableInput(this, 'bankAccount');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
