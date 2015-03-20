define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Org/OrgOrganizationalUnitRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrgOrganizationalUnit',
        actionUrl: '#OrgOrganizationalUnits',

		bindings: function () {

            var self = this;
            var result = {
			'#orgNumber': 'orgNumber',
			'#name': 'name',
			'#abbr': 'abbr',
			'#locationAbbr': 'locationAbbr',
			'#sysLocationId': { observe: 'sysLocationId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.sysLocation
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#orgTypeId': { observe: 'orgTypeId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.orgType
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#emailFrom': 'emailFrom',
			'#emailTo': 'emailTo',
			'#isEgdokPrintAlways': 'isEgdokPrintAlways',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#orgAccountingAreaId': { observe: 'orgAccountingAreaId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.orgAccountingArea
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'orgNumber', 'numeric');
			this.disableInput(this, 'name');
			this.disableInput(this, 'abbr');
			this.disableInput(this, 'locationAbbr');
			this.disableInput(this, 'sysLocationId', 'select');
			this.disableInput(this, 'orgTypeId', 'select');
			this.disableInput(this, 'emailFrom');
			this.disableInput(this, 'emailTo');
			this.disableInput(this, 'isEgdokPrintAlways');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'orgAccountingAreaId', 'select');

            return this;
        }
    });

    return view;
});
