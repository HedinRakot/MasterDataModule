define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsCoreDataProductLocalizationRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsCoreDataProductLocalization',
        actionUrl: '#InsCoreDataProductLocalizations',

		bindings: function () {

            var self = this;
            var result = {
			'#insCoreDataProductId': 'insCoreDataProductId',
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
			this.disableInput(this, 'insCoreDataProductId', 'numeric');
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
