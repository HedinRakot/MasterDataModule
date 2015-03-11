define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsProductCombinationTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsProductCombinationType',
        actionUrl: '#InsProductCombinationTypes',

		bindings: {
			'#description': 'description',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');

            return this;
        }
    });

    return view;
});
