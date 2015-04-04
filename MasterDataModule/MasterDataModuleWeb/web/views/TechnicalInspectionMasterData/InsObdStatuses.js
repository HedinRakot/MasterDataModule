define([
	'base/base-object-grid-view',
'collections/TechnicalInspectionMasterData/InsObdStatuses',
'l!t!TechnicalInspectionMasterData/FilterInsObdStatus',
'l!t!TechnicalInspectionMasterData/InsObdStatusRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsObdStatus',
        editUrl: '#InsObdStatuses',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
