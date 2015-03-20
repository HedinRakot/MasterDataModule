define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/CoreDataProductLocalizationRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'CoreDataProductLocalization',
        actionUrl: '#CoreDataProductLocalizations',

		bindings: function () {

            var self = this;
            var result = {
			'#coreDataProductId': 'coreDataProductId',
			'#sysLanguageId': { observe: 'sysLanguageId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.sysLanguage
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#productName': 'productName',
			'#description': 'description',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'coreDataProductId', 'numeric');
			this.disableInput(this, 'sysLanguageId', 'select');
			this.disableInput(this, 'productName');
			this.disableInput(this, 'description');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
