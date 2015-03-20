define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/DriverSchoolExamRecognitionTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'DriverSchoolExamRecognitionType',
        actionUrl: '#DriverSchoolExamRecognitionTypes',

		bindings: function () {

            var self = this;
            var result = {
			'#driverSchoolId': 'driverSchoolId',
			'#examRecognitionTypeId': { observe: 'examRecognitionTypeId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.drlExamRecognitionType
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'driverSchoolId', 'numeric');
			this.disableInput(this, 'examRecognitionTypeId', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
