define([
	'base/base-object-grid-view',
'collections/CommonMasterData/Employee/EmpEmployees',
'l!t!CommonMasterData/Employee/FilterEmpEmployee',
'l!t!CommonMasterData/Employee/EmpEmployeeRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'EmpEmployee',
        editUrl: '#EmpEmployees',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'personalNumber', title: this.resources.personalNumber },
				{ field: 'name', title: this.resources.name },
				{ field: 'middleName', title: this.resources.middleName },
				{ field: 'lastName', title: this.resources.lastName },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
