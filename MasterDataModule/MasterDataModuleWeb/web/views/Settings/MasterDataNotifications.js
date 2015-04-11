define([
'base/base-object-grid-view',
'collections/Settings/MasterDataNotifications',
'l!t!Settings/FilterMasterDataNotifications'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
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
				{ field: 'subject', title: this.resources.subject },
			];
		}

	});

	return view;
});
