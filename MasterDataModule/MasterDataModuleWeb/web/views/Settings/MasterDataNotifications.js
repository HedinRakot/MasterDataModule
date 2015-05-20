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
		addNewModelInline: true,
		showAddButton: true,
		showEditButton: true,
		showDeleteButton: true,

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'notificationType', title: this.resources.notificationType , collection: this.options.notificationType, defaultText: this.resources.pleaseSelect},
				{ field: 'isAlertOn', title: this.resources.isAlertOn , headerTitle: this.resources.isAlertOn, checkbox: true},
				{ field: 'alertCheckStatus', title: this.resources.alertCheckStatus , collection: this.options.alertCheckStatus, defaultText: this.resources.pleaseSelect},
				{ field: 'alertAttemptCount', title: this.resources.alertAttemptCount },
				{ field: 'message', title: this.resources.message },
				{ field: 'subject', title: this.resources.subject },
			];
		}

	});

	return view;
});
