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
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
