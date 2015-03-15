define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamClassInclusiveClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamClassInclusiveClass',
        actionUrl: '#ExamClassInclusiveClasses',

		bindings: {
			'#examClassId': 'examClassId',
			'#examClassIdInclusive': 'examClassIdInclusive',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#isConditional': 'isConditional',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examClassId', 'numeric');
			this.disableInput(this, 'examClassIdInclusive', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'isConditional');

            return this;
        }
    });

    return view;
});
