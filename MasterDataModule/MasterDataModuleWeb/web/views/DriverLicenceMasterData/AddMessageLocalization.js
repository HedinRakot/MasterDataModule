define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/MessageLocalizationRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MessageLocalization',
        actionUrl: '#MessageLocalizations',

		bindings: function () {

            var self = this;
            var result = {
			'#validationErrorNumber': 'validationErrorNumber',
			'#sysLanguageId': 'sysLanguageId',
			'#message': 'message',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'validationErrorNumber', 'numeric');
			this.disableInput(this, 'sysLanguageId', 'numeric');
			this.disableInput(this, 'message');

            return this;
        }
    });

    return view;
});
