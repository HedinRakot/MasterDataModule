define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/LegalBasisRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'LegalBasis',
        actionUrl: '#LegalBases',

		bindings: function () {

            var self = this;
            var result = {
			'#name': 'name',
			'#description': 'description',
			'#educationCertificateRequired': 'educationCertificateRequired',
			'#firstAssignation': { observe: 'firstAssignation',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.assignationType
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#messageReason': 'messageReason',
			'#messageReasonStyle': 'messageReasonStyle',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#replacementId': { observe: 'replacementId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.legalBasis
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#printName': 'printName',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'educationCertificateRequired');
			this.disableInput(this, 'firstAssignation', 'select');
			this.disableInput(this, 'messageReason');
			this.disableInput(this, 'messageReasonStyle');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'replacementId', 'select');
			this.disableInput(this, 'printName');

            return this;
        }
    });

    return view;
});
