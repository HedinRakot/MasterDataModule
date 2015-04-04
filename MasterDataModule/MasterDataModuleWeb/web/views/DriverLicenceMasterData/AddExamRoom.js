define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamRoomRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamRoom',
        actionUrl: '#ExamRooms',

		bindings: function () {

            var self = this;
            var result = {
			'#roomNumber': 'roomNumber',
			'#placeAmount': 'placeAmount',
			'#orgOrganizationalUnitId': { observe: 'orgOrganizationalUnitId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.orgOrganizationalUnit
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#name1': 'name1',
			'#name2': 'name2',
			'#name3': 'name3',
			'#streetHouseNumber': 'streetHouseNumber',
			'#zipCode': 'zipCode',
			'#zipBox': 'zipBox',
			'#box': 'box',
			'#city': 'city',
			'#phone1': 'phone1',
			'#fax': 'fax',
			'#email': 'email',
			'#sysCountryId': { observe: 'sysCountryId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.sysCountry
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'roomNumber', 'numeric');
			this.disableInput(this, 'placeAmount', 'numeric');
			this.disableInput(this, 'orgOrganizationalUnitId', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'name1');
			this.disableInput(this, 'name2');
			this.disableInput(this, 'name3');
			this.disableInput(this, 'streetHouseNumber');
			this.disableInput(this, 'zipCode');
			this.disableInput(this, 'zipBox');
			this.disableInput(this, 'box');
			this.disableInput(this, 'city');
			this.disableInput(this, 'phone1');
			this.disableInput(this, 'fax');
			this.disableInput(this, 'email');
			this.disableInput(this, 'sysCountryId', 'select');

            return this;
        }
    });

    return view;
});
