define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataSiteCheckResults',
'l!t!Settings/FilterMasterDataSiteCheckResults',
'l!t!Settings/MasterDataSiteCheckResultsRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MasterDataSiteCheckResults',
        editUrl: '#MasterDataSiteCheckResults',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'checkStatus', title: this.resources.checkStatus },
				{ field: 'checkDate', title: this.resources.checkDate , format: '{0:d}'},
				{ field: 'message', title: this.resources.message },
				{ field: 'attempt', title: this.resources.attempt },
				{ field: 'masterDataSiteInfoId', title: this.resources.masterDataSiteInfoId },
			];
		}

	});

	return view;
});
