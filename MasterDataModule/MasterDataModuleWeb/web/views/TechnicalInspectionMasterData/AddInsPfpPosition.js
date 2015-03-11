define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsPfpPositionRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsPfpPosition',
        actionUrl: '#InsPfpPositions',

		bindings: {
			'#text': 'text',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'text');

            return this;
        }
    });

    return view;
});
