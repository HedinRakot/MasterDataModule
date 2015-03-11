define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsProductObjectClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsProductObjectClass',
        actionUrl: '#InsProductObjectClasses',

		bindings: {
			'#description': 'description',
			'#weightFrom': 'weightFrom',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'weightFrom', 'numeric');

            return this;
        }
    });

    return view;
});
