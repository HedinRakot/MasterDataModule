define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamStationRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamStation',
        actionUrl: '#ExamStations',

		bindings: {
			'#ordFederalStateId': 'ordFederalStateId',
			'#place': 'place',
			'#description': 'description',
			'#sortOrder': 'sortOrder',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'ordFederalStateId', 'numeric');
			this.disableInput(this, 'place');
			this.disableInput(this, 'description');
			this.disableInput(this, 'sortOrder', 'numeric');

            return this;
        }
    });

    return view;
});
