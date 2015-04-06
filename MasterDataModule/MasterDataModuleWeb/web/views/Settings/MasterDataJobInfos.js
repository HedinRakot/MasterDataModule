define([
	'base/base-object-grid-view',
'collections/Settings/MasterDataJobInfos',
'l!t!Settings/FilterMasterDataJobInfo',
'l!t!Settings/MasterDataJobInfoRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MasterDataJobInfo',
        editUrl: '#MasterDataJobInfos',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'connectionString', title: this.resources.connectionString },
				{ field: 'tableName', title: this.resources.tableName },
				{ field: 'timeoutChecking', title: this.resources.timeoutChecking },
				{ field: 'name', title: this.resources.name },
				{ field: 'jobName', title: this.resources.jobName },
			];
		}

	});

	return view;
});
