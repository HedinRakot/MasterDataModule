define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataNotificationsMasterDataSubscribersRsps',
'l!t!Settings/FilterMasterDataNotificationsMasterDataSubscribersRsp',
'l!t!Settings/MasterDataNotificationsMasterDataSubscribersRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MasterDataNotificationsMasterDataSubscribersRsp',
        editUrl: '#MasterDataNotificationsMasterDataSubscribersRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'masterDataNotificationsId', title: this.resources.masterDataNotificationsId },
				{ field: 'masterDataSubscribersId', title: this.resources.masterDataSubscribersId },
			];
		}

	});

	return view;
});
