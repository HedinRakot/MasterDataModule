define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataWcfCheckResults',
'l!t!Settings/FilterMasterDataWcfCheckResults',
'l!t!Settings/MasterDataWcfCheckResultsRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MasterDataWcfCheckResults',
        editUrl: '#MasterDataWcfCheckResults',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'checkStatus', title: this.resources.checkStatus },
				{ field: 'checkDate', title: this.resources.checkDate , format: '{0:d}'},
				{ field: 'message', title: this.resources.message },
				{ field: 'attempt', title: this.resources.attempt },
				{ field: 'masterDataWcfInfoId', title: this.resources.masterDataWcfInfoId },
			];
		}

	});

	return view;
});
