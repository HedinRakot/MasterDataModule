define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamClassRestrictedClassRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamClassRestrictedClass',
        actionUrl: '#ExamClassRestrictedClasses',

		bindings: function () {

            var self = this;
            var result = {
			'#examClassId': 'examClassId',
			'#examClassIdRestricted': { observe: 'examClassIdRestricted',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.examClass
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
			this.disableInput(this, 'examClassIdRestricted', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
