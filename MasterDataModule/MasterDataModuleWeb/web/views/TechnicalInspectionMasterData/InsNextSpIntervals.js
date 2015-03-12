define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsNextSpIntervals',
    'l!t!TechnicalInspectionMasterData/FilterInsNextSpInterval',
    'l!t!TechnicalInspectionMasterData/InsNextSpIntervalRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';
	debugger;
	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsNextSpInterval',
        editUrl: '#InsNextSpIntervals',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'insProductObjectTypeId', title: this.resources.insProductObjectTypeId },
				{ field: 'insProductObjectClassId', title: this.resources.insProductObjectClassId },
				{ field: 'ageMonthFrom', title: this.resources.ageMonthFrom },
				{ field: 'ageMonthTo', title: this.resources.ageMonthTo },
				{ field: 'spInterval', title: this.resources.spInterval },
			];
		}
	});

	return view;
});
