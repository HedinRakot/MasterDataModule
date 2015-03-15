define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/LegalBasisRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'LegalBasis',
        actionUrl: '#LegalBases',

		bindings: {
			'#name': 'name',
			'#description': 'description',
			'#educationCertificateRequired': 'educationCertificateRequired',
			'#firstAssignation': 'firstAssignation',
			'#messageReason': 'messageReason',
			'#messageReasonStyle': 'messageReasonStyle',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#replacementId': 'replacementId',
			'#printName': 'printName',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'educationCertificateRequired');
			this.disableInput(this, 'firstAssignation', 'numeric');
			this.disableInput(this, 'messageReason');
			this.disableInput(this, 'messageReasonStyle');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'replacementId', 'numeric');
			this.disableInput(this, 'printName');

            return this;
        }
    });

    return view;
});
