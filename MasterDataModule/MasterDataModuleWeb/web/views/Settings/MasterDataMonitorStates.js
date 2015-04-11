define([
'base/base-object-grid-view',
'collections/Settings/MasterDataMonitorStates',
'l!t!Settings/FilterMasterDataMonitorState'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'MasterDataMonitorState',
        editUrl: '#MasterDataMonitorStates',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'reconfigure', title: this.resources.reconfigure , headerTitle: this.resources.reconfigure, checkbox: true},
				{ field: 'reconfigureCheckingTimeout', title: this.resources.reconfigureCheckingTimeout },
			];
		}

	});

	return view;
});
