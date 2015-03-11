define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/LanguageRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'Language',
        actionUrl: '#Languages',

		bindings: {
			'#sysLanguageId': 'sysLanguageId',
			'#oldAbbr': 'oldAbbr',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'sysLanguageId', 'numeric');
			this.disableInput(this, 'oldAbbr');

            return this;
        }
    });

    return view;
});
