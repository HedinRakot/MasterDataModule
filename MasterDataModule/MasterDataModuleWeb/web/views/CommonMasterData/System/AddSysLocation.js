define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/SysLocationRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SysLocation',
        actionUrl: '#SysLocations',

		bindings: function () {

            var self = this;
            var result = {
			'#locationCode': 'locationCode',
			'#locationName': 'locationName',
			'#sysCountryId': { observe: 'sysCountryId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.sysCountry
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#ordFederalStateId': { observe: 'ordFederalStateId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.ordFederalState
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'locationCode');
			this.disableInput(this, 'locationName');
			this.disableInput(this, 'sysCountryId', 'select');
			this.disableInput(this, 'ordFederalStateId', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
