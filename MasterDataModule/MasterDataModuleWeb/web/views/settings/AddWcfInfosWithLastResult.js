define([
	'base/base-object-add-view',
    'l!t!Settings/WcfInfosWithLastResultRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'WcfInfosWithLastResult',
        actionUrl: '#WcfInfosWithLastResults',

		bindings: function () {

            var self = this;
            var result = {
			'#name': 'name',
			'#lastResult': 'lastResult',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field

            return this;
        }
    });

    return view;
});