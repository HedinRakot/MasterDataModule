define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamRecognitionTypeExamClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamRecognitionTypeExamClass',
        actionUrl: '#ExamRecognitionTypeExamClasses',

		bindings: function () {

            var self = this;
            var result = {
			'#examRecognitionTypeId': 'examRecognitionTypeId',
			'#examClassId': { observe: 'examClassId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.examClass
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examRecognitionTypeId', 'numeric');
			this.disableInput(this, 'examClassId', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
