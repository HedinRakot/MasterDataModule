define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Employee/EmpEmployeeSysRoleRsps',
    'l!t!CommonMasterData/Employee/FilterEmpEmployeeSysRoleRsp',
    'l!t!CommonMasterData/Employee/EmpEmployeeSysRoleRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'EmpEmployeeSysRoleRsp',
        editUrl: '#EmpEmployeeSysRoleRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'empEmployeeId', title: this.resources.empEmployeeId },
				{ field: 'sysRoleId', title: this.resources.sysRoleId },
			];
		}
	});

	return view;
});
