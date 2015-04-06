define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataWcfInfoRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataWcfInfo',
        actionUrl: '#MasterDataWcfInfos',

		bindings: function () {

            var self = this;
            var result = {
			'#name': 'name',
			'#wsdlPath': 'wsdlPath',
			'#timeoutChecking': 'timeoutChecking',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'wsdlPath');
			this.disableInput(this, 'timeoutChecking', 'numeric');

            return this;
        }
    });

    return view;
});
