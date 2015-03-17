define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamClassRequiredClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamClassRequiredClass',
        actionUrl: '#ExamClassRequiredClasses',

		bindings: function () {

            var self = this;
            var result = {
			'#examClassId': 'examClassId',
			'#examClassIdRequired': { observe: 'examClassIdRequired',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.examClasses
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examClassId', 'numeric');
			this.disableInput(this, 'examClassIdRequired', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
