define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Product/OrdRecognitionAreaOfWorkRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'OrdRecognitionAreaOfWorkRsp',
        actionUrl: '#OrdRecognitionAreaOfWorkRsps',

		bindings: {
			'#ordRecognitionId': 'ordRecognitionId',
			'#ordAreaOfWorkId': 'ordAreaOfWorkId',
			'#priority': 'priority',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'ordRecognitionId', 'numeric');
			this.disableInput(this, 'ordAreaOfWorkId', 'numeric');
			this.disableInput(this, 'priority', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
