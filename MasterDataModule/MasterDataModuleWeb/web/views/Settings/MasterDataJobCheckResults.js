define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataJobCheckResults',
'l!t!Settings/FilterMasterDataJobCheckResults',
'l!t!Settings/MasterDataJobCheckResultsRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MasterDataJobCheckResults',
        editUrl: '#MasterDataJobCheckResults',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'lastRunTime', title: this.resources.lastRunTime , format: '{0:d}'},
				{ field: 'checkDate', title: this.resources.checkDate , format: '{0:d}'},
				{ field: 'checkStatus', title: this.resources.checkStatus },
				{ field: 'masterDataJobInfoId', title: this.resources.masterDataJobInfoId },
			];
		}

	});

	return view;
});
