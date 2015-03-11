define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamClassMapRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamClassMap',
        actionUrl: '#ExamClassMaps',

		bindings: {
			'#examClassIdOld': 'examClassIdOld',
			'#examClassIdActual': 'examClassIdActual',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examClassIdOld', 'numeric');
			this.disableInput(this, 'examClassIdActual', 'numeric');

            return this;
        }
    });

    return view;
});
