define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/ExpPassengersTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExpPassengersType',
        actionUrl: '#ExpPassengersTypes',

		bindings: function () {

            var self = this;
            var result = {
			'#text': 'text',
			'#code': 'code',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'text');
			this.disableInput(this, 'code');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
