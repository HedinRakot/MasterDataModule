define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/InsVatTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsVatType',
        actionUrl: '#InsVatTypes',

		bindings: {
			'#description': 'description',
			'#taxCode': 'taxCode',
			'#percent': 'percent',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'taxCode');
			this.disableInput(this, 'percent', 'numeric');

            return this;
        }
    });

    return view;
});
