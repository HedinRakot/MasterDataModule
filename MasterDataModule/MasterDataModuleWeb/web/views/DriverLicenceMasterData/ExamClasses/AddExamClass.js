define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamClasses/ExamClassesRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'examClass',
        actionUrl: '#ExamClasses',

        bindings: {
            '#name': 'name',
            '#description': 'description',
            '#fromDate': 'fromDate',
            '#toDate': 'toDate',
            '#isFsClass': 'isFsClass',
            '#isMofa': 'isMofa',
            '#sortOrder': 'sortOrder'
        },

        render: function () {

            view.__super__.render.apply(this, arguments);

            //TODO foreach model field
            this.disableInput(this, 'name');
            this.disableInput(this, 'description');
            this.disableInput(this, 'fromDate', 'date');
            this.disableInput(this, 'toDate', 'date');
            this.disableInput(this, 'isFsClass');
            this.disableInput(this, 'isMofa');
            this.disableInput(this, 'sortOrder', 'numeric');

            return this;
        }
    });

    return view;
});