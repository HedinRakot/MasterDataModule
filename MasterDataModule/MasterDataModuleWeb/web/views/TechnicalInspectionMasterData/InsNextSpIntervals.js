define([
	'base/base-object-grid-view',
'collections/TechnicalInspectionMasterData/InsNextSpIntervals',
'l!t!TechnicalInspectionMasterData/FilterInsNextSpInterval',
'l!t!TechnicalInspectionMasterData/InsNextSpIntervalRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

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
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
