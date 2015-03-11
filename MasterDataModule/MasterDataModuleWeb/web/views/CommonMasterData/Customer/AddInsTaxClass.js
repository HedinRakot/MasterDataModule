define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Customer/InsTaxClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsTaxClass',
        actionUrl: '#InsTaxClasses',

		bindings: {
			'#taxClass': 'taxClass',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'taxClass');

            return this;
        }
    });

    return view;
});
