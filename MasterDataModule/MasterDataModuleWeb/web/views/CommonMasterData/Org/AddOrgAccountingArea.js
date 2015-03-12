define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Org/OrgAccountingAreaRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrgAccountingArea',
        actionUrl: '#OrgAccountingAreas',

		bindings: {
			'#accountingArea': 'accountingArea',
			'#maxOrderSum': 'maxOrderSum',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'accountingArea');
			this.disableInput(this, 'maxOrderSum', 'numeric');

            return this;
        }
    });

    return view;
});