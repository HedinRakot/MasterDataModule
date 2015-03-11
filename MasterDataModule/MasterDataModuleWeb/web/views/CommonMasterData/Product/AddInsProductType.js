define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsProductTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsProductType',
        actionUrl: '#InsProductTypes',

		bindings: {
			'#name': 'name',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');

            return this;
        }
    });

    return view;
});
