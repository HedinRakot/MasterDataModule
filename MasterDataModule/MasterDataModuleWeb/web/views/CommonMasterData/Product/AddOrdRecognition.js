define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/OrdRecognitionRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrdRecognition',
        actionUrl: '#OrdRecognitions',

		bindings: {
			'#ordRecognitionTypeId': 'ordRecognitionTypeId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#orgAccountingAreaId': 'orgAccountingAreaId',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'ordRecognitionTypeId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'orgAccountingAreaId', 'numeric');

            return this;
        }
    });

    return view;
});
