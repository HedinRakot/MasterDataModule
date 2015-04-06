define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataMonitorableInfoMasterDataNotificationsRsps',
'l!t!Settings/FilterMasterDataMonitorableInfoMasterDataNotificationsRsp',
'l!t!Settings/MasterDataMonitorableInfoMasterDataNotificationsRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MasterDataMonitorableInfoMasterDataNotificationsRsp',
        editUrl: '#MasterDataMonitorableInfoMasterDataNotificationsRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'monitorableInfoType', title: this.resources.monitorableInfoType },
				{ field: 'monitorableInfoId', title: this.resources.monitorableInfoId },
				{ field: 'masterDataNotificationsId', title: this.resources.masterDataNotificationsId },
			];
		}

	});

	return view;
});
