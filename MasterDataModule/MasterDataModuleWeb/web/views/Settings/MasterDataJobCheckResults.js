define([
'base/base-object-grid-view',
'collections/Settings/MasterDataJobCheckResults',
'l!t!Settings/FilterMasterDataJobCheckResults'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'MasterDataJobCheckResults',
        editUrl: '#MasterDataJobCheckResults',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'lastRunTime', title: this.resources.lastRunTime , format: '{0:d}'},
				{ field: 'checkDate', title: this.resources.checkDate , format: '{0:d}'},
				{ field: 'checkStatus', title: this.resources.checkStatus },
				{ field: 'masterDataJobInfoId', title: this.resources.masterDataJobInfoId },
			];
		}

	});

	return view;
});
