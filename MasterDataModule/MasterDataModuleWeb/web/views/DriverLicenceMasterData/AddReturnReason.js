define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ReturnReasonRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ReturnReason',
        actionUrl: '#ReturnReasons',

		bindings: {
			'#name': 'name',
			'#description': 'description',
			'#text1': 'text1',
			'#text2': 'text2',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'text1');
			this.disableInput(this, 'text2');

            return this;
        }
    });

    return view;
});
