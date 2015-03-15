define([
	'base/base-object-add-view',
    'l!t!TechnicalInspectionMasterData/InsUnitCodeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'InsUnitCode',
        actionUrl: '#InsUnitCodes',

		bindings: {
			'#orgAccountingAreaId': 'orgAccountingAreaId',
			'#ordFederalStateId': 'ordFederalStateId',
			'#ordAreaOfWorkId': 'ordAreaOfWorkId',
			'#unitCode': 'unitCode',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'orgAccountingAreaId', 'numeric');
			this.disableInput(this, 'ordFederalStateId', 'numeric');
			this.disableInput(this, 'ordAreaOfWorkId', 'numeric');
			this.disableInput(this, 'unitCode');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
