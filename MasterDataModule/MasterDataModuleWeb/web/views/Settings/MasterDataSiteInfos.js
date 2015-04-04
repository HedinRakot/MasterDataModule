define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataSiteInfos',
'l!t!Settings/FilterMasterDataSiteInfo',
'l!t!Settings/MasterDataSiteInfoRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MasterDataSiteInfo',
        editUrl: '#MasterDataSiteInfos',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'name', title: this.resources.name },
				{ field: 'timeoutChecking', title: this.resources.timeoutChecking },
				{ field: 'sitePath', title: this.resources.sitePath },
			];
		}

	});

	return view;
});
