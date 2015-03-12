define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Customer/OrdCustomerInfoRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrdCustomerInfo',
        actionUrl: '#OrdCustomerInfos',

		bindings: {
			'#textValue': 'textValue',
			'#numberValue': 'numberValue',
			'#infoType': 'infoType',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'textValue');
			this.disableInput(this, 'numberValue', 'numeric');
			this.disableInput(this, 'infoType', 'numeric');

            return this;
        }
    });

    return view;
});