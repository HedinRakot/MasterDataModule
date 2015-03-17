define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamConstraintExamClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamConstraintExamClass',
        actionUrl: '#ExamConstraintExamClasses',

		bindings: function () {

            var self = this;
            var result = {
			'#examConstraintId': 'examConstraintId',
			'#examClassId': 'examClassId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
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
