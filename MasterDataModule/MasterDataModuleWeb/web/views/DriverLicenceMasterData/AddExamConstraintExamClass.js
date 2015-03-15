define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamConstraintExamClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamConstraintExamClass',
        actionUrl: '#ExamConstraintExamClasses',

		bindings: {
			'#examConstraintId': 'examConstraintId',
			'#examClassId': 'examClassId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examConstraintId', 'numeric');
			this.disableInput(this, 'examClassId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
