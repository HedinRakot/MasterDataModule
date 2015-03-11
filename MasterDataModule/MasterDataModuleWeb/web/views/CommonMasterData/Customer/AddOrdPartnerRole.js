define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Customer/OrdPartnerRoleRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrdPartnerRole',
        actionUrl: '#OrdPartnerRoles',

		bindings: {
			'#sapQualifier': 'sapQualifier',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'sapQualifier');

            return this;
        }
    });

    return view;
});
