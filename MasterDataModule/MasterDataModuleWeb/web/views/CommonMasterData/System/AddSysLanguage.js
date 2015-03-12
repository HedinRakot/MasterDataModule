define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/SysLanguageRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SysLanguage',
        actionUrl: '#SysLanguages',

		bindings: {
			'#sapId': 'sapId',
			'#sapIdIso': 'sapIdIso',
			'#resourceFileName': 'resourceFileName',
			'#isAvailable': 'isAvailable',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'sapId');
			this.disableInput(this, 'sapIdIso');
			this.disableInput(this, 'resourceFileName');
			this.disableInput(this, 'isAvailable');

            return this;
        }
    });

    return view;
});