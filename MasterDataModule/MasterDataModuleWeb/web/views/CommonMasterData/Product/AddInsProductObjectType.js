define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsProductObjectTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsProductObjectType',
        actionUrl: '#InsProductObjectTypes',

		bindings: function () {

            var self = this;
            var result = {
			'#description': 'description',
			'#sapId': 'sapId',
			'#isAuNecessary': 'isAuNecessary',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'sapId');
			this.disableInput(this, 'isAuNecessary');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
