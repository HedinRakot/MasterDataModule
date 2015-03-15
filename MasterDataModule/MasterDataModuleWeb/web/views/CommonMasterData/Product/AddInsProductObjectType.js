define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsProductObjectTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsProductObjectType',
        actionUrl: '#InsProductObjectTypes',

		bindings: {
			'#description': 'description',
			'#sapId': 'sapId',
			'#isAuNecessary': 'isAuNecessary',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
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
