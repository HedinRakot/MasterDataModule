define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsPfpVehicleTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsPfpVehicleType',
        actionUrl: '#InsPfpVehicleTypes',

		bindings: function () {

            var self = this;
            var result = {
			'#description': 'description',
			'#imageFileName': 'imageFileName',
			'#isPolygonDataValid': 'isPolygonDataValid',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'imageFileName');
			this.disableInput(this, 'isPolygonDataValid');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
