define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsPfpVehicleTypes',
    'l!t!TechnicalInspectionMasterData/FilterInsPfpVehicleType',
    'l!t!TechnicalInspectionMasterData/InsPfpVehicleTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsPfpVehicleType',
        editUrl: '#InsPfpVehicleTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'description', title: this.resources.description },
				{ field: 'imageFileName', title: this.resources.imageFileName },
				{ field: 'isPolygonDataValid', title: this.resources.isPolygonDataValid , headerTitle: this.resources.isPolygonDataValid, checkbox: true},
			];
		}
	});

	return view;
});