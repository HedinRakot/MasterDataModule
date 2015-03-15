define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Employee/EmpEmployeeOrgCostCenterRsps',
    'l!t!CommonMasterData/Employee/FilterEmpEmployeeOrgCostCenterRsp',
    'l!t!CommonMasterData/Employee/EmpEmployeeOrgCostCenterRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'EmpEmployeeOrgCostCenterRsp',
        editUrl: '#EmpEmployeeOrgCostCenterRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'orgCostCenterId', title: this.resources.orgCostCenterId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
