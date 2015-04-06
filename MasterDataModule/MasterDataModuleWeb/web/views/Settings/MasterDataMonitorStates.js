define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataMonitorStates',
'l!t!Settings/FilterMasterDataMonitorState',
'l!t!Settings/MasterDataMonitorStateRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
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
