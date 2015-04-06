define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataNotifications',
'l!t!Settings/FilterMasterDataNotifications',
'l!t!Settings/MasterDataNotificationsRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MasterDataNotifications',
        editUrl: '#MasterDataNotifications',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'notificationType', title: this.resources.notificationType },
				{ field: 'isAlertOn', title: this.resources.isAlertOn , headerTitle: this.resources.isAlertOn, checkbox: true},
				{ field: 'alertCheckStatus', title: this.resources.alertCheckStatus },
				{ field: 'alertAttemptCount', title: this.resources.alertAttemptCount },
				{ field: 'message', title: this.resources.message },
			];
		}

	});

	return view;
});
