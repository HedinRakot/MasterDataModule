define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsObdStatusRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsObdStatus',
        actionUrl: '#InsObdStatuses',

		bindings: {
			'#name': 'name',
			'#description': 'description',
			'#auView': 'auView',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'auView');

            return this;
        }
    });

    return view;
});
