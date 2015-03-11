define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/ExpPassengersTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExpPassengersType',
        actionUrl: '#ExpPassengersTypes',

		bindings: {
			'#text': 'text',
			'#code': 'code',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'text');
			this.disableInput(this, 'code');

            return this;
        }
    });

    return view;
});
