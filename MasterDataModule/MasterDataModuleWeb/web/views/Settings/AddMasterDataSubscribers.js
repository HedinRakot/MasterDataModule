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
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'email');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
