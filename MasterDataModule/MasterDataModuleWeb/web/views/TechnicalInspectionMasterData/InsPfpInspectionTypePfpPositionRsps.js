define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsPfpInspectionTypePfpPositionRsps',
    'l!t!TechnicalInspectionMasterData/FilterInsPfpInspectionTypePfpPositionRsp',
    'l!t!TechnicalInspectionMasterData/InsPfpInspectionTypePfpPositionRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsPfpInspectionTypePfpPositionRsp',
        editUrl: '#InsPfpInspectionTypePfpPositionRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'insPfpPositionId', title: this.resources.insPfpPositionId },
				{ field: 'insPfpInspectionTypeId', title: this.resources.insPfpInspectionTypeId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
