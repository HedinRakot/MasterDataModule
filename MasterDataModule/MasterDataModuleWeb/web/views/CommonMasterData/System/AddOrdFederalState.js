define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/System/OrdFederalStateRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrdFederalState',
        actionUrl: '#OrdFederalStates',

		bindings: function () {

            var self = this;
            var result = {
			'#federalStateName': 'federalStateName',
			'#description': 'description',
			'#sysCountryId': { observe: 'sysCountryId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.sysCountry
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'federalStateName');
			this.disableInput(this, 'description');
			this.disableInput(this, 'sysCountryId', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
