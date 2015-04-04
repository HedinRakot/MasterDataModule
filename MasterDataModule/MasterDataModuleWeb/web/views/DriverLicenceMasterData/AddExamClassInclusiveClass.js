define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamClassInclusiveClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamClassInclusiveClass',
        actionUrl: '#ExamClassInclusiveClasses',

		bindings: function () {

            var self = this;
            var result = {
			'#examClassId': 'examClassId',
			'#examClassIdInclusive': { observe: 'examClassIdInclusive',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.examClass
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#isConditional': 'isConditional',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examClassId', 'numeric');
			this.disableInput(this, 'examClassIdInclusive', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'isConditional');

            return this;
        }
    });

    return view;
});
