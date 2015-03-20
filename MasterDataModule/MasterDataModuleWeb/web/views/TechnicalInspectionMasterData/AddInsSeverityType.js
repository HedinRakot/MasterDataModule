define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsSeverityTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsSeverityType',
        actionUrl: '#InsSeverityTypes',

		bindings: function () {

            var self = this;
            var result = {
			'#name': 'name',
			'#description': 'description',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
