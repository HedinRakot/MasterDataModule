define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataSiteInfoRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataSiteInfo',
        actionUrl: '#MasterDataSiteInfos',

		bindings: function () {

            var self = this;
            var result = {
			'#name': 'name',
			'#timeoutChecking': 'timeoutChecking',
			'#sitePath': 'sitePath',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'timeoutChecking', 'numeric');
			this.disableInput(this, 'sitePath');

            return this;
        }
    });

    return view;
});
