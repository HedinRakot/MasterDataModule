define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamStationRelationships'
], function (BaseView , TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamStation',
        actionUrl: '#ExamStations',

		bindings: function () {

            var self = this;
            var result = {
			'#ordFederalStateId': { observe: 'ordFederalStateId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.ordFederalState
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#place': 'place',
			'#description': 'description',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#sortOrder': 'sortOrder',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'ordFederalStateId', 'select');
			this.disableInput(this, 'place');
			this.disableInput(this, 'description');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'sortOrder', 'numeric');

            return this;
        }
		,events: {
		}
    });

    return view;
});
