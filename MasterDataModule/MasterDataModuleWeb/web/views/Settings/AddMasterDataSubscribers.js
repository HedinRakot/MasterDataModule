define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataSubscribersRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataSubscribers',
        actionUrl: '#MasterDataSubscribers',

		bindings: function () {

            var self = this;
            var result = {
			'#email': 'email',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'email');

            return this;
        }
    });

    return view;
});
