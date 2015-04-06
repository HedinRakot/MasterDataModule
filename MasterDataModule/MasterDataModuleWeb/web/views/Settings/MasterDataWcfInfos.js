define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataWcfInfos',
'l!t!Settings/FilterMasterDataWcfInfo',
'l!t!Settings/MasterDataWcfInfoRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MasterDataWcfInfo',
        editUrl: '#MasterDataWcfInfos',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'name', title: this.resources.name },
				{ field: 'wsdlPath', title: this.resources.wsdlPath },
				{ field: 'timeoutChecking', title: this.resources.timeoutChecking },
			];
		}

	});

	return view;
});
