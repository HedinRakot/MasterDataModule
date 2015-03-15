define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamClassRestrictedClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamClassRestrictedClass',
        actionUrl: '#ExamClassRestrictedClasses',

		bindings: {
			'#examClassId': 'examClassId',
			'#examClassIdRestricted': 'examClassIdRestricted',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examClassId', 'numeric');
			this.disableInput(this, 'examClassIdRestricted', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
