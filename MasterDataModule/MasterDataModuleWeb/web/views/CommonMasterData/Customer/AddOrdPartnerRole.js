define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Customer/OrdPartnerRoleRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrdPartnerRole',
        actionUrl: '#OrdPartnerRoles',

		bindings: function () {

            var self = this;
            var result = {
			'#sapQualifier': 'sapQualifier',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'sapQualifier');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
