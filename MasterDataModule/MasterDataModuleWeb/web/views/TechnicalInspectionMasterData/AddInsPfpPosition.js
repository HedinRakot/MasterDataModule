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
			'#topId': 'topId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'text');
			this.disableInput(this, 'topId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
