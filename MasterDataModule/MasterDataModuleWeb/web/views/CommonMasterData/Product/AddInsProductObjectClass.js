define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/InsProductObjectClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsProductObjectClass',
        actionUrl: '#InsProductObjectClasses',

		bindings: function () {

            var self = this;
            var result = {
			'#description': 'description',
			'#weightFrom': 'weightFrom',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'weightFrom', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
