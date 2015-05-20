define([
'base/base-object-grid-view',
'collections/Settings/GetJobsStatuses',
'l!t!Settings/FilterGetJobsStatus'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'GetJobsStatus',
        editUrl: '#GetJobsStatuses',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'checkStatus', title: this.resources.checkStatus },
				{ field: 'checkDate', title: this.resources.checkDate , format: '{0:d}'},
				{ field: 'lastRunTime', title: this.resources.lastRunTime , format: '{0:d}'},
				{ field: 'name', title: this.resources.name },
				{ field: 'jobName', title: this.resources.jobName },
				{ field: 'logTypeInfoId', title: this.resources.logTypeInfoId },
			];
		}

	});

	return view;
});
