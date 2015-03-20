define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/CoreDataProductRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'CoreDataProduct',
        actionUrl: '#CoreDataProducts',

		bindings: function () {

            var self = this;
            var result = {
			'#insCoreDataProductId': 'insCoreDataProductId',
			'#minAge': 'minAge',
			'#maxAge': 'maxAge',
			'#examType': 'examType',
			'#priorTimeInMonths': 'priorTimeInMonths',
			'#expirationInMonth': 'expirationInMonth',
			'#repeatTimeInDays': 'repeatTimeInDays',
			'#trainingCertFlag': 'trainingCertFlag',
			'#resultFlag': 'resultFlag',
			'#multiplyFlag': 'multiplyFlag',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#isMofaPrint': 'isMofaPrint',
			'#isAdditionalProduct': 'isAdditionalProduct',
			'#isPrepaymentRequired': 'isPrepaymentRequired',
			'#isMandatory': 'isMandatory',
			'#feProductNumber': 'feProductNumber',
			'#repeatTimeInDaysReduced': 'repeatTimeInDaysReduced',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'insCoreDataProductId', 'numeric');
			this.disableInput(this, 'minAge', 'numeric');
			this.disableInput(this, 'maxAge', 'numeric');
			this.disableInput(this, 'examType', 'numeric');
			this.disableInput(this, 'priorTimeInMonths', 'numeric');
			this.disableInput(this, 'expirationInMonth', 'numeric');
			this.disableInput(this, 'repeatTimeInDays', 'numeric');
			this.disableInput(this, 'trainingCertFlag');
			this.disableInput(this, 'resultFlag');
			this.disableInput(this, 'multiplyFlag');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'isMofaPrint');
			this.disableInput(this, 'isAdditionalProduct');
			this.disableInput(this, 'isPrepaymentRequired');
			this.disableInput(this, 'isMandatory');
			this.disableInput(this, 'feProductNumber');
			this.disableInput(this, 'repeatTimeInDaysReduced', 'numeric');

            return this;
        }
    });

    return view;
});
