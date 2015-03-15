define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Org/OrgInspectionDeviceRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrgInspectionDevice',
        actionUrl: '#OrgInspectionDevices',

		bindings: {
			'#debitorCustomerNumber': 'debitorCustomerNumber',
			'#identification': 'identification',
			'#newIdentification': 'newIdentification',
			'#oldIdentification': 'oldIdentification',
			'#type': 'type',
			'#serialNumber': 'serialNumber',
			'#name': 'name',
			'#description': 'description',
			'#lastInspectionDate': 'lastInspectionDate',
			'#lastInspectionResult': 'lastInspectionResult',
			'#inspectionDate': 'inspectionDate',
			'#inspectionInterval': 'inspectionInterval',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'debitorCustomerNumber');
			this.disableInput(this, 'identification');
			this.disableInput(this, 'newIdentification');
			this.disableInput(this, 'oldIdentification');
			this.disableInput(this, 'type');
			this.disableInput(this, 'serialNumber');
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'lastInspectionDate', 'date');
			this.disableInput(this, 'lastInspectionResult');
			this.disableInput(this, 'inspectionDate', 'date');
			this.disableInput(this, 'inspectionInterval', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
