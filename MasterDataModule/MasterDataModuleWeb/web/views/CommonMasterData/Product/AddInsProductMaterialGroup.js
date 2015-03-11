define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsProductMaterialGroupRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsProductMaterialGroup',
        actionUrl: '#InsProductMaterialGroups',

		bindings: {
			'#description': 'description',
			'#sapId': 'sapId',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'sapId');

            return this;
        }
    });

    return view;
});
