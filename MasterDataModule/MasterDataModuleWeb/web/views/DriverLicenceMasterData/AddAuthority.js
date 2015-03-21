define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/AuthorityRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'Authority',
        actionUrl: '#Authorities',

		bindings: function () {

            var self = this;
            var result = {
			'#authorityNumber': 'authorityNumber',
			'#name': 'name',
			'#description': 'description',
			'#isCertificateRequired': 'isCertificateRequired',
			'#returnType': 'returnType',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#name2': 'name2',
			'#streetHouseNumber': 'streetHouseNumber',
			'#zipCode': 'zipCode',
			'#city': 'city',
			'#sysCountryId': { observe: 'sysCountryId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.sysCountry
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#phone1': 'phone1',
			'#phone2': 'phone2',
			'#fax': 'fax',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'authorityNumber');
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'isCertificateRequired');
			this.disableInput(this, 'returnType', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'name2');
			this.disableInput(this, 'streetHouseNumber');
			this.disableInput(this, 'zipCode');
			this.disableInput(this, 'city');
			this.disableInput(this, 'sysCountryId', 'select');
			this.disableInput(this, 'phone1');
			this.disableInput(this, 'phone2');
			this.disableInput(this, 'fax');

            return this;
        }
    });

    return view;
});
