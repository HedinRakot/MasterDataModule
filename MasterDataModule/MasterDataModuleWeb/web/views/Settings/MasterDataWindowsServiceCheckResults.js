define([
'base/base-object-grid-view',
'collections/Settings/MasterDataWindowsServiceCheckResults',
'l!t!Settings/FilterMasterDataWindowsServiceCheckResults'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'MasterDataWindowsServiceCheckResults',
        editUrl: '#MasterDataWindowsServiceCheckResults',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'checkStatus', title: this.resources.checkStatus },
				{ field: 'checkDate', title: this.resources.checkDate , format: '{0:d}'},
				{ field: 'message', title: this.resources.message },
				{ field: 'attempt', title: this.resources.attempt },
				{ field: 'masterDataWindowsServiceInfoId', title: this.resources.masterDataWindowsServiceInfoId },
			];
		}

	});

	return view;
});
