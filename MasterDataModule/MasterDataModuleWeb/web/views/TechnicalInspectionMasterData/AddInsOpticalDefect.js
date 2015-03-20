define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsOpticalDefectRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsOpticalDefect',
        actionUrl: '#InsOpticalDefects',

		bindings: function () {

            var self = this;
            var result = {
			'#name': 'name',
			'#description': 'description',
			'#isCustom': 'isCustom',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'isCustom');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
