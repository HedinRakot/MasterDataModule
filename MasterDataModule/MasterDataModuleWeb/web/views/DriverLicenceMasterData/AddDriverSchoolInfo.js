define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/DriverSchoolInfoRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'DriverSchoolInfo',
        actionUrl: '#DriverSchoolInfos',

		bindings: function () {

            var self = this;
            var result = {
			'#schoolInfoId': { observe: 'schoolInfoId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.schoolInfo
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#driverSchoolId': 'driverSchoolId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'schoolInfoId', 'select');
			this.disableInput(this, 'driverSchoolId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
