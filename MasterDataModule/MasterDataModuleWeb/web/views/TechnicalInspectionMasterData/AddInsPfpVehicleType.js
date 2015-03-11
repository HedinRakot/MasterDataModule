define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsPfpVehicleTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsPfpVehicleType',
        actionUrl: '#InsPfpVehicleTypes',

		bindings: {
			'#description': 'description',
			'#imageFileName': 'imageFileName',
			'#isPolygonDataValid': 'isPolygonDataValid',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'imageFileName');
			this.disableInput(this, 'isPolygonDataValid');

            return this;
        }
    });

    return view;
});
