define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Employee/EmpCashPermissionTypes',
    'l!t!CommonMasterData/Employee/FilterEmpCashPermissionType',
    'l!t!CommonMasterData/Employee/EmpCashPermissionTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'EmpCashPermissionType',
        editUrl: '#EmpCashPermissionTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
			];
		}
	});

	return view;
});
