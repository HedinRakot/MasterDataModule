define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Customer/OrdContactPersonFunctionRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrdContactPersonFunction',
        actionUrl: '#OrdContactPersonFunctions',

		bindings: {
			'#sapId': 'sapId',
			'#description': 'description',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'sapId');
			this.disableInput(this, 'description');

            return this;
        }
    });

    return view;
});