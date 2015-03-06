define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsCoreDataProducts/InsCoreDataProductsRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'insCoreDataProduct',
        actionUrl: '#InsCoreDataProducts',

        bindings: {
            '#name': 'name',
            '#description': 'description',
            '#fromDate': 'fromDate',
            '#toDate': 'toDate',
            '#productNumber': 'productNumber',
        },

        render: function () {

            view.__super__.render.apply(this, arguments);
            
            //TODO foreach model field
            this.disableInput(this, 'name');
            this.disableInput(this, 'description');
            this.disableInput(this, 'fromDate', 'date');
            this.disableInput(this, 'toDate', 'date');
            this.disableInput(this, 'productNumber');

            //todo disable select button

            return this;
        }
    });

    return view;
});