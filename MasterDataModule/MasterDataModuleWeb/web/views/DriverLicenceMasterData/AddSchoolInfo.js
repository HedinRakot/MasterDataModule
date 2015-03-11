define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/SchoolInfoRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SchoolInfo',
        actionUrl: '#SchoolInfos',

		bindings: {
			'#text': 'text',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'text');

            return this;
        }
    });

    return view;
});
