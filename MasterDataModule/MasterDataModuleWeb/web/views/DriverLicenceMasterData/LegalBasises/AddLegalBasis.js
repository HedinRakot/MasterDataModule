define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/LegalBasises/LegalBasisesRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'legalBasis',
        actionUrl: '#LegalBasises',

        bindings: function () {

            return {
                '#name': 'name',
                '#description': 'description',
                '#fromDate': 'fromDate',
                '#toDate': 'toDate',
                '#isAttestationRequired': 'isAttestationRequired',
                '#messageReason': 'messageReason',
                '#messageReasonStyle': 'messageReasonStyle',
                '#printName': 'printName',
                '#replacementId': {
                    observe: 'replacementId',
                    selectOptions: {
                        labelPath: 'name',
                        valuePath: 'id',
                        collection: this.options.legalBasises,
                        defaultOption: {
                            label: 'Ersatzrechtsgrund auswählen',
                            value: null
                        }
                    },
                },
                '#isFirstAssignation': {
                    observe: 'isFirstAssignation',
                    selectOptions: {
                        labelPath: 'name',
                        valuePath: 'id',
                        collection: this.options.assignationTypes,
                        defaultOption: {
                            label: 'Art auswählen',
                            value: null
                        }
                    },
                },
            };
        },

        render: function () {

            view.__super__.render.apply(this, arguments);

            //TODO foreach model field
            this.disableInput(this, 'name');
            this.disableInput(this, 'description');
            this.disableInput(this, 'fromDate', 'date');
            this.disableInput(this, 'toDate', 'date');
            this.disableInput(this, 'isAttestationRequired');
            this.disableInput(this, 'messageReason');
            this.disableInput(this, 'messageReasonStyle');
            this.disableInput(this, 'printName');
            this.disableInput(this, 'isFirstAssignation', 'select');
            this.disableInput(this, 'replacementId', 'select');

            return this;
        }
    });

    return view;
});