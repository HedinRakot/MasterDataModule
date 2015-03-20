define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsCoreDataProductGroupRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsCoreDataProductGroup',
        actionUrl: '#InsCoreDataProductGroups',

		bindings: function () {

            var self = this;
            var result = {
			'#name': 'name',
			'#defaultDuration': 'defaultDuration',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'defaultDuration', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
