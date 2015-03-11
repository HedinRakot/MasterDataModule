define([
	'base/base-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsValidPeriods',
    'l!t!TechnicalInspectionMasterData/FilterInsValidPeriod',
    'l!t!TechnicalInspectionMasterData/InsValidPeriodRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsValidPeriod',
        editUrl: '#InsValidPeriods',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'description', title: this.resources.description },
				{ field: 'validityPeriod', title: this.resources.validityPeriod },
				{ field: 'isNextTerminPossible', title: this.resources.isNextTerminPossible , headerTitle: this.resources.isNextTerminPossible, checkbox: true},
			];
		}
	});

	return view;
});
