define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamClassArgeMapRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamClassArgeMap',
        actionUrl: '#ExamClassArgeMaps',

		bindings: {
			'#examNameArge': 'examNameArge',
			'#examClassId': 'examClassId',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examNameArge');
			this.disableInput(this, 'examClassId', 'numeric');

            return this;
        }
    });

    return view;
});
