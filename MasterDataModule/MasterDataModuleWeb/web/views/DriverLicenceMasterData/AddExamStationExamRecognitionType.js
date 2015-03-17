define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamStationExamRecognitionTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamStationExamRecognitionType',
        actionUrl: '#ExamStationExamRecognitionTypes',

		bindings: function () {

            var self = this;
            var result = {
			'#examStationId': 'examStationId',
			'#examRecognitionTypeId': 'examRecognitionTypeId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examStationId', 'numeric');
			this.disableInput(this, 'examRecognitionTypeId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
