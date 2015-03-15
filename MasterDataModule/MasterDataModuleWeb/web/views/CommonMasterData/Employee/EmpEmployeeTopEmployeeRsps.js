define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Employee/EmpEmployeeTopEmployeeRsps',
    'l!t!CommonMasterData/Employee/FilterEmpEmployeeTopEmployeeRsp',
    'l!t!CommonMasterData/Employee/EmpEmployeeTopEmployeeRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'EmpEmployeeTopEmployeeRsp',
        editUrl: '#EmpEmployeeTopEmployeeRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'topEmployeeId', title: this.resources.topEmployeeId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
