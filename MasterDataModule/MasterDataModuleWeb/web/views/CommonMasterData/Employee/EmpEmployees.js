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
				{ field: 'domain', title: this.resources.domain },
				{ field: 'userName', title: this.resources.userName },
				{ field: 'windowsUserName', title: this.resources.windowsUserName },
				{ field: 'isSsoAllowed', title: this.resources.isSsoAllowed , headerTitle: this.resources.isSsoAllowed, checkbox: true},
				{ field: 'isEmergencyLoginAllowed', title: this.resources.isEmergencyLoginAllowed , headerTitle: this.resources.isEmergencyLoginAllowed, checkbox: true},
				{ field: 'name', title: this.resources.name },
				{ field: 'middleName', title: this.resources.middleName },
				{ field: 'lastName', title: this.resources.lastName },
				{ field: 'comment', title: this.resources.comment },
				{ field: 'sexType', title: this.resources.sexType },
				{ field: 'title', title: this.resources.title },
				{ field: 'birthdate', title: this.resources.birthdate , format: '{0:d}'},
			];
		}
	});

	return view;
});
