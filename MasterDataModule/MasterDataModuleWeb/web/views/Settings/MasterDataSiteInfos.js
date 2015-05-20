define([
'base/base-object-grid-view',
'collections/Settings/MasterDataSiteInfos',
'l!t!Settings/FilterMasterDataSiteInfo'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'MasterDataSiteInfo',
        editUrl: '#MasterDataSiteInfos',
		addNewModelInline: true,
		showAddButton: true,
		showEditButton: true,
		showDeleteButton: true,

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'name', title: this.resources.name },
				{ field: 'timeoutChecking', title: this.resources.timeoutChecking },
				{ field: 'sitePath', title: this.resources.sitePath },
				{ field: 'logTypeInfoId', title: this.resources.logTypeInfoId , collection: this.options.logTypeInfo, defaultText: this.resources.pleaseSelect},
			];
		}

	});

	return view;
});
