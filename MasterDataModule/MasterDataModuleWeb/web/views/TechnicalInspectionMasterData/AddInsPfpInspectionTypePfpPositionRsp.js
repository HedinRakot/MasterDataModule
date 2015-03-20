define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsPfpInspectionTypePfpPositionRspRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsPfpInspectionTypePfpPositionRsp',
        actionUrl: '#InsPfpInspectionTypePfpPositionRsps',

		bindings: function () {

            var self = this;
            var result = {
			'#insPfpPositionId': 'insPfpPositionId',
			'#insPfpInspectionTypeId': 'insPfpInspectionTypeId',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'insPfpPositionId', 'numeric');
			this.disableInput(this, 'insPfpInspectionTypeId', 'numeric');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
