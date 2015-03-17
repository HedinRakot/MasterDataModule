define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamPossibleResultRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamPossibleResult',
        actionUrl: '#ExamPossibleResults',

		bindings: function () {

            var self = this;
            var result = {
			'#name': 'name',
			'#description': 'description',
			'#isFeePayable': 'isFeePayable',
			'#examCounterFlag': 'examCounterFlag',
			'#nextExamProductFlag': 'nextExamProductFlag',
			'#driverLicenceFlag': 'driverLicenceFlag',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#isMedicalAttestRequired': 'isMedicalAttestRequired',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'isFeePayable');
			this.disableInput(this, 'examCounterFlag');
			this.disableInput(this, 'nextExamProductFlag');
			this.disableInput(this, 'driverLicenceFlag');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'isMedicalAttestRequired');

            return this;
        }
    });

    return view;
});
