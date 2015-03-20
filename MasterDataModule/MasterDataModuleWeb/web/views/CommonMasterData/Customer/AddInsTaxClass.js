define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Customer/InsTaxClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsTaxClass',
        actionUrl: '#InsTaxClasses',

		bindings: function () {

            var self = this;
            var result = {
			'#taxClass': 'taxClass',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'taxClass');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
