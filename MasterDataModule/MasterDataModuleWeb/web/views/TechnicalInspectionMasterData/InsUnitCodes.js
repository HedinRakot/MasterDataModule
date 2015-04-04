define([
	'base/base-object-grid-view',
'collections/TechnicalInspectionMasterData/InsUnitCodes',
'l!t!TechnicalInspectionMasterData/FilterInsUnitCode',
'l!t!TechnicalInspectionMasterData/InsUnitCodeRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsUnitCode',
        editUrl: '#InsUnitCodes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'orgAccountingAreaId', title: this.resources.orgAccountingAreaId },
				{ field: 'ordFederalStateId', title: this.resources.ordFederalStateId },
				{ field: 'ordAreaOfWorkId', title: this.resources.ordAreaOfWorkId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
