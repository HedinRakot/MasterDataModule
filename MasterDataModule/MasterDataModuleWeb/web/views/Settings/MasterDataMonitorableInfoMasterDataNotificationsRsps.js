define([
'base/base-object-grid-view',
'collections/Settings/MasterDataMonitorableInfoMasterDataNotificationsRsps',
'l!t!Settings/FilterMasterDataMonitorableInfoMasterDataNotificationsRsp',
'Settings/Custom.MasterDataMonitorableInfoMasterDataNotificationsRsp'
], function (BaseView, Collection, FilterView, CustomColumns) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'MasterDataMonitorableInfoMasterDataNotificationsRsp',
        editUrl: '#MasterDataMonitorableInfoMasterDataNotificationsRsps',
		addNewModelInline: true,
		showAddButton: true,
		showEditButton: true,
		showDeleteButton: true,

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return $.merge( CustomColumns(),
[
				{ field: 'monitorableInfoType', title: this.resources.monitorableInfoType , collection: this.options.checkModuleType, defaultText: this.resources.pleaseSelect},
				{ field: 'monitorableInfoId', title: this.resources.monitorableInfoId },
				{ field: 'masterDataNotificationsId', title: this.resources.masterDataNotificationsId , collection: this.options.masterDataNotifications, defaultText: this.resources.pleaseSelect},
			]);
		}

	});

	return view;
});
