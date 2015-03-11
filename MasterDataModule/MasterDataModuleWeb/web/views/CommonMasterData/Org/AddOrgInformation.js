define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Org/OrgInformationRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrgInformation',
        actionUrl: '#OrgInformation',

		bindings: {
			'#name': 'name',
			'#value': 'value',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'value');

            return this;
        }
    });

    return view;
});
