define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamConstraintRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamConstraint',
        actionUrl: '#ExamConstraints',

		bindings: {
			'#name': 'name',
			'#description': 'description',
			'#constraintType': 'constraintType',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'constraintType', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
