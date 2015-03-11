define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsTaxCodeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsTaxCode',
        actionUrl: '#InsTaxCodes',

		bindings: {
			'#taxCode': 'taxCode',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'taxCode');

            return this;
        }
    });

    return view;
});
