define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/LanguageRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'Language',
        actionUrl: '#Languages',

		bindings: function () {

            var self = this;
            var result = {
			'#sysLanguageId': { observe: 'sysLanguageId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.sysLanguage
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#oldAbbr': 'oldAbbr',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'sysLanguageId', 'select');
			this.disableInput(this, 'oldAbbr');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
