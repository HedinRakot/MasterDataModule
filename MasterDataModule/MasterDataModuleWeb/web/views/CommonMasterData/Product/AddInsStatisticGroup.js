define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsStatisticGroupRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsStatisticGroup',
        actionUrl: '#InsStatisticGroups',

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
