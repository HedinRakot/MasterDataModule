define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/SysPostCodeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SysPostCode',
        actionUrl: '#SysPostCodes',

		bindings: {
			'#postCode': 'postCode',
			'#city': 'city',
			'#street': 'street',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'postCode');
			this.disableInput(this, 'city');
			this.disableInput(this, 'street');

            return this;
        }
    });

    return view;
});
