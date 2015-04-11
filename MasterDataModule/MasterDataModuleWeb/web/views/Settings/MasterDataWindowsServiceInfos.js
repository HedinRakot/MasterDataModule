define([
'base/base-object-grid-view',
'collections/Settings/MasterDataWindowsServiceInfos',
'l!t!Settings/FilterMasterDataWindowsServiceInfo'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'MasterDataWindowsServiceInfo',
        editUrl: '#MasterDataWindowsServiceInfos',
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
				{ field: 'machineName', title: this.resources.machineName },
				{ field: 'serviceName', title: this.resources.serviceName },
				{ field: 'timeoutChecking', title: this.resources.timeoutChecking },
			];
		}

	});

	return view;
});
