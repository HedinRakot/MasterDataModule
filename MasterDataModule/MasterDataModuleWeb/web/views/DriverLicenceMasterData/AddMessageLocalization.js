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
			'#sysLanguageId': { observe: 'sysLanguageId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.sysLanguage
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#message': 'message',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'validationErrorNumber', 'numeric');
			this.disableInput(this, 'sysLanguageId', 'select');
			this.disableInput(this, 'message');

            return this;
        }
    });

    return view;
});
