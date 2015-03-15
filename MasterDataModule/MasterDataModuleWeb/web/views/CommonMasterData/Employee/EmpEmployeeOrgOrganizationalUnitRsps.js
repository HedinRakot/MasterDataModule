define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Employee/EmpEmployeeOrgOrganizationalUnitRsps',
    'l!t!CommonMasterData/Employee/FilterEmpEmployeeOrgOrganizationalUnitRsp',
    'l!t!CommonMasterData/Employee/EmpEmployeeOrgOrganizationalUnitRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'EmpEmployeeOrgOrganizationalUnitRsp',
        editUrl: '#EmpEmployeeOrgOrganizationalUnitRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'empEmployeeId', title: this.resources.empEmployeeId },
				{ field: 'orgOrganizationalUnitId', title: this.resources.orgOrganizationalUnitId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
