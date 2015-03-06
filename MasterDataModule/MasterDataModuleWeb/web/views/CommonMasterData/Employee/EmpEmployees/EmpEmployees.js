define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/EmpEmployees',
    'l!t!CommonMasterData/Employee/EmpEmployees/FilterEmpEmployees',
    'l!t!CommonMasterData/Employee/EmpEmployees/EmpEmployeesRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'empEmployee',
        editUrl: '#EmpEmployees',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
		        { field: 'lastName', title: this.resources.lastName, width: '270px' },
		        { field: 'middleName', title: this.resources.middleName },
		        { field: 'name', title: this.resources.name, width: '220px' },
		        { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
		    ];
		}
	});

	return view;
});