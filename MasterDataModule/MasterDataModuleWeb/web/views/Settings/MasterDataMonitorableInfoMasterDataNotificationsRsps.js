define([
'base/base-object-grid-view',
'collections/Settings/MasterDataMonitorableInfoMasterDataNotificationsRsps',
'l!t!Settings/FilterMasterDataMonitorableInfoMasterDataNotificationsRsp',
'Settings/Custom.MasterDataMonitorableInfoMasterDataNotificationsRsp',
'Settings/Custom.Events.MasterDataMonitorableInfoMasterDataNotificationsRsp'
], function (BaseView, Collection, FilterView, CustomColumns, CustomEvents) {
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
				{ field: 'masterDataNotificationsId', title: this.resources.masterDataNotificationsId , collection: this.options.masterDataNotifications, defaultText: this.resources.pleaseSelect},
			]);
		}

		,events: CustomEvents
	});

	return view;
});
