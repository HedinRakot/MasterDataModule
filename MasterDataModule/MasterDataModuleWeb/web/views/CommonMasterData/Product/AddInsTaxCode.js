define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsTaxCodeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsTaxCode',
        actionUrl: '#InsTaxCodes',

		bindings: function () {

            var self = this;
            var result = {
			'#taxCode': 'taxCode',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'taxCode');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
