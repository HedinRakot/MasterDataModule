define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/ExamClassMapRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'ExamClassMap',
        actionUrl: '#ExamClassMaps',

		bindings: function () {

            var self = this;
            var result = {
			'#examClassIdOld': 'examClassIdOld',
			'#examClassIdActual': { observe: 'examClassIdActual',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.examClass
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examClassIdOld', 'numeric');
			this.disableInput(this, 'examClassIdActual', 'select');

            return this;
        }
    });

    return view;
});
