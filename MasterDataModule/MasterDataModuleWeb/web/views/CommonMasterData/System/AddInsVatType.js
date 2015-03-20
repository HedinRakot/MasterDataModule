define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/InsVatTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsVatType',
        actionUrl: '#InsVatTypes',

		bindings: function () {

            var self = this;
            var result = {
			'#description': 'description',
			'#taxCode': 'taxCode',
			'#percent': 'percent',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'taxCode');
			this.disableInput(this, 'percent', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
