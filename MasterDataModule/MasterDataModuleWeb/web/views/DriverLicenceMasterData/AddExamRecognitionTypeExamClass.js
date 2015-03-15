define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamRecognitionTypeExamClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamRecognitionTypeExamClass',
        actionUrl: '#ExamRecognitionTypeExamClasses',

		bindings: {
			'#examRecognitionTypeId': 'examRecognitionTypeId',
			'#examClassId': 'examClassId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examRecognitionTypeId', 'numeric');
			this.disableInput(this, 'examClassId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
