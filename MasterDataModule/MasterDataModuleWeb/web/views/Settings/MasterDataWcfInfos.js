define([
'base/base-object-grid-view',
'collections/Settings/MasterDataWcfInfos',
'l!t!Settings/FilterMasterDataWcfInfo'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'MasterDataWcfInfo',
        editUrl: '#MasterDataWcfInfos',
		addNewModelInline: true,
		showAddButton: true,
		showEditButton: true,
		showDeleteButton: true,

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'name', title: this.resources.name },
				{ field: 'wsdlPath', title: this.resources.wsdlPath },
				{ field: 'timeoutChecking', title: this.resources.timeoutChecking },
				{ field: 'logTypeInfoId', title: this.resources.logTypeInfoId , collection: this.options.logTypeInfo, defaultText: this.resources.pleaseSelect},
			];
		}

	});

	return view;
});
