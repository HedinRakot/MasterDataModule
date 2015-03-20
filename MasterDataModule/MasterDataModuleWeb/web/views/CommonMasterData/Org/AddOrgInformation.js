define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Org/OrgInformationRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrgInformation',
        actionUrl: '#OrgInformation',

		bindings: function () {

            var self = this;
            var result = {
			'#name': 'name',
			'#value': 'value',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'value');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
