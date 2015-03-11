define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsOpticalDefectRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsOpticalDefect',
        actionUrl: '#InsOpticalDefects',

		bindings: {
			'#name': 'name',
			'#description': 'description',
			'#isCustom': 'isCustom',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'isCustom');

            return this;
        }
    });

    return view;
});
